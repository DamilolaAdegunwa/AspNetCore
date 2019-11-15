using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Microsoft.AspNetCore.Connections
{
    public abstract class StreamContext : ConnectionContext
    {
        /// <summary>
        /// Triggered when the client stream is closed.
        /// </summary>
        public virtual CancellationToken StreamClosed { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier to represent this stream in trace logs.
        /// </summary>
        public abstract string StreamId { get; set; }

        /// <summary>
        /// Represents the direction
        /// </summary>
        public abstract Direction Direction { get; }
    }

    public enum Direction
    {
        BiDirectional,
        UnidirectionalInbound,
        UnidirectionalOutbound
    }
}
