Navigate = {

    navigateToIssueForm: function () {

        var entityFormOptions = {};
        entityFormOptions.entityName = "new_salary";
        entityFormOptions.formId = "932824C8-9FA9-45DF-AA2A-DA89EF4C4E16";
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

