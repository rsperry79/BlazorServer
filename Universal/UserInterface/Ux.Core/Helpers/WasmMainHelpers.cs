using Core.Helpers;
using Core.Interfaces;

using System;
using System.Diagnostics;
using System.Net.Http;

namespace Ux.Helpers
{
    public static class WasmMainHelpers
    {
        /// <summary>
        /// Sets the universal build settings.
        /// </summary>
        /// <param name="args">The console args on build.</param>
        /// <returns>the  WebAssemblyHostBuilder <see cref="WebAssemblyHostBuilder"/>.</returns>
        public static WebAssemblyHostBuilder LoadUniveralsBuildSettings(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

            // globally defined for all templates
            builder.Services.AddTelerikBlazor();
            builder.Services.AddBootstrapCss();

            builder.Services.AddSingleton<ILocalStorage, LocalStorage>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IxServer, xServer>();
            builder.Services.AddBlazorCurrentDevice();//https://github.com/arivera12/BlazorCurrentDevice
            builder.Services.AddBlazorApplicationInsights(); //https://github.com/ivanjosipovic/blazorapplicationinsights

            return builder;
        }

        /// <summary>
        /// Sets the URI for needed dlls.
        /// </summary>
        /// <param name="prodUri"></param>
        public static void SetLoadUri(Uri prodUri, WebAssemblyHostBuilder builder)
        {

            if (Debugger.IsAttached)
            {
                builder.Services.AddTransient(sp => new HttpClient
                { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            }
            else
            {
                builder.Services.AddTransient(sp => new HttpClient
                { BaseAddress = prodUri });
            }
        }
    }
}
