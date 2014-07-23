function xhr(options) {
    /****
    
    - method
    - headers
    - url
    - data

    source: https://gist.github.com/matthewp/3099268

    */
    var deferred = Q.defer(),
    req = new XMLHttpRequest();

    req.open(options.method || 'GET', options.url, true);

    // Set request headers if provided.
    Object.keys(options.headers || {}).forEach(function (key) {
        req.setRequestHeader(key, options.headers[key]);
    });

    req.onreadystatechange = function (e) {
        if (req.readyState !== 4) {
            return;
        }

        if ([200, 304].indexOf(req.status) === -1) {
            deferred.reject(new Error('Server responded with a status of ' + req.status));
        } else {
            deferred.resolve(e.target.response);
        }
    };

    req.send(options.data || void 0);

    return deferred.promise;
}

//http://stackoverflow.com/questions/17544965/unhandled-rejection-reasons-should-be-empty
Q.stopUnhandledRejectionTracking();

(function ($) {
    $(function () {

        xhr({
            url: '/Promise/'
        }).then(
            function success(data) {
                console.log(data);
            },
            function error(error) {
                console.log(error.message);
            }
        );
    });
})(jQuery);