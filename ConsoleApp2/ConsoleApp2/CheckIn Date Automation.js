//function onChange(executionControl) {
//    var formContext = executionControl.getformContext();
//    var roomStatus = formContext.getAttribute("asnu_roomstatus").getValue();
//    if (asnu_roomstatus == "Check In") {
//        formContext.getAttribute("asnu_actualcheckoutdate").setVisible(false);
//    }
//}
function checkOutDate(executionContext) {
    var formContext = executionContext.getFormContext();
    var roomStatus = formContext.getAttribute("asnu_roomstatus").getText();
    if (roomStatus == "Check In") {
        formContext.getAttribute("asnu_checkindate").setValue(new Date());
    }
}