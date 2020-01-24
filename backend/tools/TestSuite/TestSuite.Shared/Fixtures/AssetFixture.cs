﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.ClientLibrary.Management;

namespace TestSuite.Fixtures
{
    public class AssetFixture : CreatedAppFixture
    {
        public IAssetsClient Assets { get; }

        public AssetFixture()
        {
            Assets = ClientManager.CreateAssetsClient();
        }
    }
}
