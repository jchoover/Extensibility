// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility.Data
{
    using WixToolset.Data;

    public interface IDelayedField
    {
        IntermediateField Field { get; }

        IntermediateSymbol Symbol { get; }
    }
}
