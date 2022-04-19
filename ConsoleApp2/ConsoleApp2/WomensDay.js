
function showAccountOnChange(executionContext) {
    
    var formContext = executionContext.getFormContext();
    
    var result = formContext.getAttribute("new_s_age").getValue();
    
    if (result >= 18) {

        
        formContext.getControl("new_votingdone").setVisible(true);
    }
    else {
        formContext.getControl("new_votingdone").setVisible(false);
    }
}