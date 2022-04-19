var Sdk = window.Sdk || {};
(function () {
    this.changeproductprice = function (executionContext) {
        //Get the form context
        var formContext = executionContext.getFormContext();
        var ProductName = formContext.getAttribute("new_product_name").getValue();
        //Set the field value here
        if (ProductName.toLowerCase().search("chocolate") != -1) {
            formContext.getAttribute("new_pro_price").setValue(50);
        }
        if (ProductName.toLowerCase().search("salt") != -1) {
            formContext.getAttribute("new_pro_price").setValue(100);
        }
        if (ProductName.toLowerCase().search("rice") != -1) {
            formContext.getAttribute("new_pro_price").setValue(150);
        }
    }
}).call(Sdk);