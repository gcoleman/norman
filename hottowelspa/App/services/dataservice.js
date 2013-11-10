define(['services/logger'],
    function (logger) {

        var dataservice = {
            getContactInfo: getContactInfo            
        };

        return dataservice;      
        
        //Returns contact information
        function getContactInfo(callback) {
            get(null, window.appRoutes.GeneralPaths.pathToContactInformation, callback);                      
        }







        //#region Server calls

        //Get requests
        function get(params, path, callback) {
            $.ajax({
                url: path,
                data: params,
                type: "GET"
            }).done(callback); 
        }


        //Post requests
        function post(params, path, callback) {
            $.ajax({
                url: path,
                data: params,
                type: "POST"
            }).done(callback);
        }

        //#endregion

});