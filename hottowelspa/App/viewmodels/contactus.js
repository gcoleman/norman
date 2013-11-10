define(['services/dataservice', 'services/logger'], function (dataservice, logger) {
    var title = 'Contact us';
   

    var vm = {
        activate: activate,
        title: title,
        emailAddress: "",
        telephoneNumber: ""
    };    

    return vm;

    //#region Internal Methods
    function activate() {
        $(function () {
            dataservice.getContactInfo(setcontactInfo);
            logger.log(title + ' View Activated', null, title, true);
            return true;   
            
        })
    }

    function setcontactInfo(data) {
        vm.emailAddress = data.emailAddress;
        vm.telephoneNumber = data.telephoneNumber;
        logger.log("Contact information loaded", null, "contact us", true);
    }
    //#endregion
});