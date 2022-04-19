function showAccountOnChange(executionContext) {

    var formContext = executionContext.getFormContext();

    var result = formContext.getAttribute("new_salary").getValue();

    if (result >= 80000) {


        formContext.getControl("new_tax").setVisible(true);
        formContext.getControl("new_tot_tax").setVisible(true);
    }
    else {
        formContext.getControl("new_tax").setVisible(false);
        formContext.getControl("new_tot_tax").setVisible(false);
    }
}