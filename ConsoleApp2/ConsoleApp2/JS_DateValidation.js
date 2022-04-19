function GetDateFieldValues(executionContext) {
    try {
        //Get the form contextvar formContext = executionContext.getFormContext();
        //Get value of the field here, Give field logical name here
        var formContext = executionContext.getFormContext();
        var dateOfBirth = formContext.getAttribute("new_s_dob").getValue();
        //Get Year
        Xrm.Utility.alertDialog(dateOfBirth.getFullYear());
        
        //Get Month
        Xrm.Utility.alertDialog(dateOfBirth.getMonth());
        //Get Date(Day)
        Xrm.Utility.alertDialog(dateOfBirth.getDate());
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
        Xrm.Utility.alertDialog("Advance Happy Birthday");
    }
}