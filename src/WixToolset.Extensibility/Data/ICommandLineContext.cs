// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility.Data
{
    using System;
    using WixToolset.Extensibility.Services;

    public interface ICommandLineContext
    {
        IWixToolsetServiceProvider ServiceProvider { get; }

        IExtensionManager ExtensionManager { get; set; }

        ICommandLineArguments Arguments { get; set; }
    }
}
