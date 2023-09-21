"use strict";

var originalFetch = window.fetch;

window.fetch = function (requestInfo, options) {
    if (requestInfo !== undefined) {

        var cdn = "https://sperry.blob.core.windows.net/public/TableUseful/";
        if (requestInfo.includes('_framework')) {
            return originalFetch("" + cdn + requestInfo, options);
        }
        //if (requestInfo === '_framework/blazor.boot.json') {
        //    return originalFetch(
        //        'https://sperry.blob.core.windows.net/public/TableUseful/_framework/blazor.boot.json',
        //        options);
        //}

        return originalFetch.apply(this, arguments);
    }
};

