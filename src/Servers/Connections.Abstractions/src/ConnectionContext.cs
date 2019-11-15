// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Connections
{
    /// <summary>
    /// Encapsulates all information about an individual connection.
    /// </summary>
    public abstract class ConnectionContext : ConnectionContextBase
    {
        /// <summary>
        /// Gets or sets the <see cref="IDuplexPipe"/> that can be used to read or write data on this connection.
        /// </summary>
        public abstract IDuplexPipe Transport { get; set; }
    }
}
