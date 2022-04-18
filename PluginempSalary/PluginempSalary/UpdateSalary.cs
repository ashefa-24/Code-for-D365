using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;


namespace PluginempSalary
{
    public class UpdateSalary : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                {
                    Entity entity = (Entity)context.InputParameters["Target"];

                    if (entity.LogicalName == "new_employee1")
                    {
                        if (entity.Attributes.Contains("new_salary") == true)
                        {
                            // Get the current attribute value
                            int tickersymbol = Convert.ToInt32(entity["new_salary"]);
                            int bonus = 2000;
                            // Update the attribute
                            entity["new_salary"] = tickersymbol + bonus;
                        }
                    }
                }
            }
            catch (InvalidPluginExecutionException e)
            {
                // catch exception
                throw new InvalidPluginExecutionException("An error has occurred: " + e.Message);
            }
        }
    }
}
