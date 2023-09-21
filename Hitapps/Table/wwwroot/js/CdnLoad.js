window.addEventListener('load', function () {
    if (webassemblySupported) {

        LoadBlazor();
    }
    else {
        window.location = window.location + "BrowserNotSupported.html";
    }
})



window.xServer_OnLoad = () => {
    doReadyCheck();
};

window.HitAppInit = () => {
    doReadyCheck();
};

let doReadyCheck = () => {
    if (webassemblySupported) {
        if (document.readyState === 'complete') {
            window.xServer = window.top.xServer;

            LoadBlazor();
        } else {
            document.onreadystatechange = () => {
                if (document.readyState === 'complete') {
                    window.xServer = window.top.xServer;

                    LoadBlazor();
                }
            }
        }
    } else {
        window.location = window.location + "BrowserNotSupported.html";
    } }


let init = false;
var LoadBlazor = () => {
    if (init == false) {
        Blazor.start({
            logLevel: 1, // LogLevel.Debug

            loadBootResource: function (type, name, defaultUri, integrity) {
                console.log(
                    `Loading: '${type}', '${name}', 'https://sperry.blob.core.windows.net/public/TableUseful/', '${integrity}'`
                );
                switch (type) {
                    case 'dotnetjs':
                        return `https://sperry.blob.core.windows.net/public/TableUseful/_framework/${name}`;
                    case 'dotnetwasm':
                        return `https://sperry.blob.core.windows.net/public/TableUseful/_framework/${name}`;
                    case 'timezonedata':
                        return `https://sperry.blob.core.windows.net/public/TableUseful/_framework/${name}`;
                }
            }
        }).then(function () {
                var customScript = window.document.createElement('script');
            customScript.setAttribute('src', 'https://server.js');
                 window.document.head.appendChild(customScript);
            })
            .catch(ex => console.log(ex));;
        init = true;
    }
};
