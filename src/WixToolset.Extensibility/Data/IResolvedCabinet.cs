// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility.Data
{
    public interface IResolvedCabinet
    {
        CabinetBuildOption BuildOption { get; set; }

        string Path { get; set; }
    }
}
