const originalFetch = window.fetch;

window.fetch = function (requestInfo, options) {
    if (requestInfo !== undefined) {
        if (requestInfo.includes('https://sperry.blob.core.windows.net/public/TableUseful/_framework')) {
            return originalFetch(
                `${requestInfo}`,
                options);
        }

        let cdn = "https://sperry.blob.core.windows.net/public/TableUseful/";
        if (requestInfo.includes('_framework')) {
            return originalFetch(`${cdn}${requestInfo}`, options);
        }

        return originalFetch.apply(this, arguments);
    }

};