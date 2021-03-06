﻿// Copyright (c) 2019 DHGMS Solutions and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Blazor.Hosting;

namespace Dhgms.AspNetCoreContrib.Example.WebBlazorWasm
{
    /// <summary>
    /// Represents the core Program start up logic.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point for the program.
        /// </summary>
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }

        /// <summary>
        /// Helper to create the App Host.
        /// </summary>
        /// <returns>Host Builder object.</returns>
        public static IWebAssemblyHostBuilder CreateHostBuilder() =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
