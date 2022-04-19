function SetTheFieldRequirementLevel(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        //Set as Business Required
        formContext.getAttribute("new_dateofbirth").setRequiredLevel("required");
        
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}