'use strict';

window.addEventListener('load', function () {
    xServer = top.window.xServer;
    Blazor.navigateTo('/index');
});

window.xServer_OnLoad = function () {};

window.HitAppInit = function () {
    if (webassemblySupported) {
        LoadBlazor();
    } else {
        window.location = window.location + "BrowserNotSupported.html";
    }
};

window.xServer_OnLoad = function () {};

var init = false;
var LoadBlazor = function LoadBlazor() {
    if (init == false) {
        Blazor.start({
            loadBootResource: function loadBootResource(type, name, defaultUri, integrity) {
                console.log('Loading: \'' + type + '\', \'' + name + '\', \'https://sperry.blob.core.windows.net/public/TableUseful/\', \'' + integrity + '\'');
                switch (type) {
                    case 'dotnetjs':
                        return 'https://sperry.blob.core.windows.net/public/TableUseful/_framework/' + name;
                    case 'dotnetwasm':
                        return 'https://sperry.blob.core.windows.net/public/TableUseful/_framework/' + name;
                    case 'timezonedata':
                        return 'https://sperry.blob.core.windows.net/public/TableUseful/_framework/' + name;
                }
            }
        });
        init = true;
    }
};

