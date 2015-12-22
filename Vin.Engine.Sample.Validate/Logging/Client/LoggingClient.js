// JavaScript source code
// JQuery 1.8 or higher must be ready to use by caller
(function (logClient, $, undefined) {
    var browser = 'ClientBrowser: ' + window.navigator.userAgent;

    function log(logMessage, url) {
        var isValid = validate(logMessage, url);

        if (isValid) {
            var appendedUrl;

            if (startsWith(url, "http")) {
                appendedUrl = url + "/api/v1/logging";
            } else {
                appendedUrl = "http://" + url + "/api/v1/logging";
            }

            $.ajax({
                url: appendedUrl,
                data: logMessage,
                type: "POST",
                contentType: 'application/json',
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });

            return true;
        } else {
            return false;
        }
    }

    function startsWith(string, prefix) {
        return string.slice(0, prefix.length) === prefix;
    }

    function validate(logMessage, url) {
        if (logMessage.Category !== 'Error' || logMessage.Category !== 'Trace') {
            return false;
        }

        if (logMessage.Message === false) {
            return false;
        }
        
        if (logMessage.Application === false) {
            return false;
        }

        if (url === false) {
            return false;
        }

        return true;
    }

    logClient.logError = function(application, error, url) {
        var logMessage = { Application: application, LogDate: new Date().getDate(), Category: 'Error', Machine: browser, Message: error };
        log(logMessage, url);
    }

    logClient.logInfo = function(application, info, url) {
        var logMessage = { Application: application, LogDate: new Date().getDate(), Category: 'Trace', Machine: browser, Message: info };
        log(logMessage, url);
    }
})(window.logClient = window.logClient || {}, jQuery);