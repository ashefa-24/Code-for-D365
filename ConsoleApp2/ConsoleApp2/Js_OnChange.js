function onLoad() {
    if (Xrm.Page.getAttribute("new_name").getValue() == null) {
        Xrm.Page.ui.setFormNotification("Don't forget to add name!", "INFO", "1");
    }
}

function onChange() {
    if (Xrm.Page.getAttribute("new_name").getValue() != null) {
        Xrm.Page.ui.setFormNotification("THANKS for adding the name", "INFO", "1");
    }
}
