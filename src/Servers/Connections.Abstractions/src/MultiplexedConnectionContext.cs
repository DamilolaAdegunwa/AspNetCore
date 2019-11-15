// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Connections
{
    public abstract class MultiplexedConnectionContext : ConnectionContextBase
    {
        public abstract ValueTask<StreamContext> AcceptAsync();
        public abstract ValueTask<StreamContext> ConnectAsync(IFeatureCollection features = null, bool unidirectional = false);
    }
}
