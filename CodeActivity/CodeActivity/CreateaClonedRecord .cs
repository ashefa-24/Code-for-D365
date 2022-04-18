using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
namespace CodeActivityTask
{
    public class CreateaClonedRecord : CodeActivity
    {
        [Input("RoomNumber")]
        public InArgument<string> RoomNumber { get; set; }
        ITracingService tracingservice;
        IOrganizationService service;
        IWorkflowContext context;



        string base64XML = string.Empty, docId = string.Empty;
        Guid scanActivityGuid = Guid.Empty;
        Guid prescriptionGuid = Guid.Empty;
        protected override void Execute(CodeActivityContext executionContext)
        {
            //IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            //IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            //IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            tracingservice = executionContext.GetExtension<ITracingService>();
            context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                CreateClonedRecord(RoomNumber.Get(executionContext));
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        private void CreateClonedRecord(string roomnumber)
        {
            Entity room = new Entity("asnu_room");
            room["asnu_roomnumber"] = roomnumber;
            room["asnu_floornumber"] = 1;
            room["asnu_rtype"] = new OptionSetValue(738490002);
            room["asnu_checkindate"] = DateTime.Now;
            room["asnu_actualcheckoutdate"] = DateTime.Now.AddDays(2);
            room["asnu_plannedcheckoutdate"] = DateTime.Now.AddDays(2);

            service.Create(room);
        }

    }
}
