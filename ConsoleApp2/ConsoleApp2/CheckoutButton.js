//function checkOutButton(executionContext) {
//    var formContext = executionContext.getFormContext();
//    var currentDate = new Date();
//    var planned = formContext.getAttribute("asnu_plannedcheckoutdate").setValue(currentDate);
//    var actual = formContext.getAttribute("asnu_actualcheckoutdate").setValue(currentDate);
//}
//function checkOutButton(ctrl) {
//    use restrict;
//    var formContext = ctrl;
//    //var currentDate = new Date();
//    formContext.getAttribute("asnu_plannedcheckoutdate").setValue("1994-11-05T13:15:30");
//    formContext.getAttribute("asnu_actualcheckoutdate").setValue("1994-11-05T13:15:30");
//}
function checkOutButton(primaryControl) {
    var formContext = primaryControl;

    formContext.getAttribute("asnu_plannedcheckoutdate").setValue(new Date());
    formContext.getAttribute("asnu_actualcheckoutdate").setValue(new Date());
    var entity = {};
    entity.subject = "Checkout Task Completed";

    Xrm.WebApi.online.createRecord("task", entity).then(
        function success(result) {
            var newEntityId = result.id;
        },
        function (error) {
            Xrm.Utility.alertDialog(error.message);
        }
    );
}