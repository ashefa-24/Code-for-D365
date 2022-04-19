Navigate = {

    navigateToIssueForm: function () {

        var entityFormOptions = {};
        entityFormOptions.entityName = "new_admission";
        entityFormOptions.formId = "CF93A67E-0798-4BB1-A5AD-1DCF6C9A880D";
        entityFormOptions.openInNewWindow = true;


        // Open the form.
        Xrm.Navigation.openForm(entityFormOptions).then(
            function (success) {
                console.log(success);
            },
            function (error) {
                console.log(error);
            });
    }
}

