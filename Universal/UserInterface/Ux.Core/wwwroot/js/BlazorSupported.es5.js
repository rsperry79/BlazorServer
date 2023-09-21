

//check if webassembly is supported
"use strict";

var webassemblySupported = (function () {
    try {
        if (typeof WebAssembly === "object" && typeof WebAssembly.instantiate === "function") {
            var _module2 = new WebAssembly.Module(Uint8Array.of(0x0, 0x61, 0x73, 0x6d, 0x01, 0x00, 0x00, 0x00));
            if (_module2 instanceof WebAssembly.Module) return new WebAssembly.Instance(_module2) instanceof WebAssembly.Instance;
        }
    } catch (e) {}
    return false;
})();

