function onSave(context) {
    var saveEvent = context.getEventArgs();
    if (Xrm.Page.getAttribute("new_s_email").getValue() == null) {
        // *** Note: I am using an alert for testing a notification maybe better!
        alert("Put in a Email Address!");
        saveEvent.preventDefault();
    }
}