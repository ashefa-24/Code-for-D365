using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;


namespace Plugin
{
    public class TaskCreation : IPlugin
    {
        public void Create(IOrganizationService serviceProvider)
        {
            //throw new NotImplementedException();
            try
            {
                Entity TaskEntity = new Entity("task");
                TaskEntity["subject"] = "Test subject";
                TaskEntity["regardingobjectid"] = new EntityReference("asnu_room").Id;
                serviceProvider.Create(TaskEntity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}