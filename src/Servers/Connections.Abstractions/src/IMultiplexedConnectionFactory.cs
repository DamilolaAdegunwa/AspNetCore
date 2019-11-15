using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Connections
{
    public interface IMultiplexedConnectionFactory
    {
        /// <summary>
        /// Creates a new connection to an endpoint.
        /// </summary>
        /// <param name="endpoint">The <see cref="EndPoint"/> to connect to.</param>
        /// <param name="features">A feature collection to pass options when connecting.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None" />.</param>
        /// <returns>
        /// A <see cref="ValueTask{TResult}" /> that represents the asynchronous connect, yielding the <see cref="ConnectionContext" /> for the new connection when completed.
        /// </returns>
        ValueTask<MultiplexedConnectionContext> ConnectAsync(EndPoint endpoint, IFeatureCollection features = null, CancellationToken cancellationToken = default);
    }
}
