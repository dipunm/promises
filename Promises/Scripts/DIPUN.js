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

function CustomPromiseSync() {
    var deferred = Q.defer();
    deferred.resolve(1);
    return deferred.promise;
}

(function ($) {
    $(function () {
        $('#trigger').click(function () {
            $('#loading-icon').show();
            clear();
            run();
            //numberwang();
        });

        hideLoader();

        function numberwang() {
            CustomPromiseSync().then(function (n) {
                return n + 3;
            }).then(function (n) {
                $('#console').append(n);
                $('#console').append("\n");
            });
        }

        function clear() {
            $('#console').text('');
            $('#title').text('');
            $('#content').html('');
        }

        JSON.parse2 = function (data) {
            throw new Error("JSON.parse error!");
        };

        function setTitle(data) {
            $('#title').text(data.title);
            return data;
        }

        function printParagraph(text) {
            $('#content').append("<p>" + text + "</p>");
        }

        function hideLoader() {
            $('#loading-icon').hide();
        }

        function run() {
            xhr({
                url: '/Promise/'
            })
            .then(JSON.parse)
            .then(setTitle)
            .then(function(json) {
                for (var i in json.locations) {
                    xhr({
                        url: json.locations[i]
                    }).then(printParagraph);
                }
            })
            .catch(function(err) {
                $('#console').append(err.message);
            })
            .then(hideLoader);
        }

    });
})(jQuery);