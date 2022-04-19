function SetLookUpFieldValue(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        var lookupValue = new Array();
        var lookupValue[0]= new Object();
        lookupValue[0].new_cus_name = "Anitha";//Guid of the Record to be set
        lookupValue[0].new_cus_address = "T Nagar"; //Name of the record to be set
        lookupValue[0].new_cus_city = "Chennai";
        lookupValue[0].new_cus_phoneno = 9080012345;
        lookupValue[0].entityType = "customer"; //Entity Logical Name
        formContext.getAttribute("customer").setValue(lookupValue);
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}