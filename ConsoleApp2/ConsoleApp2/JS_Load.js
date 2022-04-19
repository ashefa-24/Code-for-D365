function OnLoad(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        //Sample code for On Load Event
        Xrm.Utility.alertDialog("Please Enter all the fields!!!");
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}