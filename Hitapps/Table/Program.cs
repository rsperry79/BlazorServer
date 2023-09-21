using Core.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Table.Useful;
using Ux.Helpers;
using Table.Useful.Models;
using xServer;

namespace Table.Useful
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WasmMainHelpers.LoadUniveralsBuildSettings(args);

            WasmMainHelpers.SetLoadUri(new Uri("https://sperry.blob.core.windows.net/public/TableUseful/"), builder);
            builder.RootComponents.Add<App>("#app");

            // hitapp specific
            builder.Services.AddSingleton<ILocalStorageSettingsBase, LocalStorageSettings>();
            builder.Services.AddSingleton<TableViewModel>();
            builder.Services.AddSingleton<HitData>();
            builder.Services.AddSingleton<JudgementData>();


            return builder.Build().RunAsync();
        }

    }
}
