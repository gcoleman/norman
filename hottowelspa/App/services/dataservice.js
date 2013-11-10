define(['services/logger'],
    function (logger) {
        var dataservice = {
            getContactInfo: getContactInfo            
        };

        return dataservice;      
        
        function getContactInfo(callback) {
            get(null, "HotTowel/ContactInfo", callback);
                      
        }

        function get(params, path, callback) {
            $.ajax({
                url: path,
                data: params,
                type: "GET"
            }).done(callback); 
        }        

});