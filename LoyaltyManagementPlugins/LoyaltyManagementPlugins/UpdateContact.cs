//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LoyaltyManagementPlugins
//{
//    public class Class1
//    {
//    }
//}

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyManagementPlugins
{
    public class UpdateContact : IPlugin
    {
        IOrganizationService service;
        ITracingService tracingService;
        IPluginExecutionContext context;
        Entity entity;
        public void Execute(IServiceProvider serviceProvider)
        {
            context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                entity = (Entity)context.InputParameters["Target"];
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                service = serviceFactory.CreateOrganizationService(context.UserId);
                tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

                try
                {
                    if (entity.LogicalName == "asnu_productpurchase")//doubt
                    {
                        switch (context.Stage)
                        {
                            case 40://post-operation

                                switch (context.MessageName)
                                {
                                    case "Create":
                                        CalculateSpendAnalyzer();
                                        tracingService.Trace("4");
                                        Calculatequantity();
                                        tracingService.Trace("5");
                                        CalculateRedeemPoints();
                                        tracingService.Trace("6");
                                        break;
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        private void CalculateSpendAnalyzer()
        {
            try
            {
                if (entity.Attributes.Contains("cr039_contact"))
                {
                    Guid contactname = entity.GetAttributeValue<EntityReference>("cr039_contact").Id;
                    Entity contact = service.Retrieve("contact", contactname, new ColumnSet("cr039_spendanalyzer"));
                    tracingService.Trace("1");

                    if (contact.Attributes.Contains("cr039_spendanalyzer"))
                    {
                        contact["cr039_spendanalyzer"] = contact.GetAttributeValue<Int32>("cr039_spendanalyzer") + (Int32)entity.GetAttributeValue<Int32>("asnu_newtotalprice");
                    }
                    else
                    {
                        contact["cr039_spendanalyzer"] = 0 + (Int32)(entity.GetAttributeValue<Int32>("asnu_newtotalprice"));
                    }

                    service.Update(contact);
                    tracingService.Trace("3");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Calculatequantity()
        {
            try
            {
                if (entity.Attributes.Contains("asnu_productpurchase")) 
                {
                    Guid contactname = entity.GetAttributeValue<EntityReference>("asnu_productpurchase").Id;
                    Entity products = service.Retrieve("asnu_product", contactname, new ColumnSet("asnu_remainingquantity"));//doubt 
                    tracingService.Trace("8");

                    if (products.Attributes.Contains("asnu_remainingquantity"))
                    {
                        products["asnu_remainingquantity"] = products.GetAttributeValue<Int32>("asnu_remainingquantity") - (Int32)entity.GetAttributeValue<Int32>("asnu_productquantity");
                    }
                    tracingService.Trace("11");
                    service.Update(products);
                    tracingService.Trace("9");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalculateRedeemPoints()
        {
            try
            {
                if (entity.Attributes.Contains("cr039_contact"))
                {
                    Guid contactname = entity.GetAttributeValue<EntityReference>("cr039_contact").Id;
                    Guid cardname = entity.GetAttributeValue<EntityReference>("cr039_contact").Id;//  cr3ea_typeofcard
                    Entity contact = service.Retrieve("contact", contactname, new ColumnSet("cr039_redeempoints"));
                    Entity card = service.Retrieve("contact", cardname, new ColumnSet("cr039_cardtype"));

                    if (contact.Attributes.Contains("cr039_redeempoints"))
                    {
                        contact["cr039_redeempoints"] = contact.GetAttributeValue<Int32>("cr039_redeempoints") + (Int32)entity.GetAttributeValue<Int32>("asnu_pointsearned");
                        Int32 totalredeempoints = (Int32)contact["cr039_redeempoints"];
                        if (totalredeempoints >= 1001 && totalredeempoints <= 2500)
                        {
                            contact["cr039_cardtype"] = "gold";
                        }
                        else if (totalredeempoints >= 2501)
                        {
                            contact["cr039_cardtype"] = "platinum";
                        }
                        else
                        {
                            contact["cr039_cardtype"] = "silver";
                        }
                    }
                    else
                    {
                        contact["cr039_redeempoints"] = 0 + (Int32)(entity.GetAttributeValue<Int32>("asnu_pointsearned"));
                    }

                    service.Update(contact);
                    tracingService.Trace("3");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}

