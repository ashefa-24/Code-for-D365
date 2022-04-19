function orderDeliver(primaryControl) {
    var formContext = primaryControl;
    var orderStatus = formContext.getAttribute("asnu_remaining").getValue();
    if (orderStatus == 0) {
        formContext.getAttribute("asnu_opstatus").setValue(738490001);
    } else {
        formContext.getAttribute("asnu_opstatus").setValue(738490002);
    }
}