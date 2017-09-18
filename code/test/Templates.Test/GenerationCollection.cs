﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace Microsoft.Templates.Test
{
    [CollectionDefinition("GenerationCollection")]
    public class GenerationCollection : ICollectionFixture<GenerationFixture>
    {
    }

    [CollectionDefinition("BuildCodeBehindCollection")]
    public class BuildCodeBehindCollection : ICollectionFixture<BuildCodeBehindFixture>
    {
    }

    [CollectionDefinition("BuildMVVMBasicCollection")]
    public class BuildMVVMBasicCollection : ICollectionFixture<BuildMVVMBasicFixture>
    {
    }

    [CollectionDefinition("BuildMVVMLightCollection")]
    public class BuildMVVMLightCollection : ICollectionFixture<BuildMVVMLightFixture>
    {
    }
}
