function onLoad(executionContext) {

    var formContext = executionContext.getFormContext();

   

    formContext.getControl("new_tax").setVisible(false);
    formContext.getControl("new_tot_tax").setVisible(false);
    
}