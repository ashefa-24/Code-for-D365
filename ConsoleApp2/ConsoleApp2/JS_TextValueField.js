function GetTextValue(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        //Get text value of the field here, Give field logical name here
        var textValue = formContext.getAttribute("new_s_address").getValue();
        Xrm.Utility.alertDialog("The address you have entered is"+ textValue);
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}