function SetOptionSetDataBaseValue(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        //Set the field value here
        formContext.getAttribute("new_age").setValue(53);
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}