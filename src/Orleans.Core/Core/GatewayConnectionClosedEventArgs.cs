using System;
using Orleans.Runtime;

namespace Orleans
{
    /// <summary>
    /// Handler for gateway connection closed notifications.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event arguments.</param>
    public delegate void GatewayConnectionClosedHandler(object sender, GatewayConnectionClosedEventArgs e);

    /// <summary>
    /// Event arguments for gateway connectivity events.
    /// </summary>
    public class GatewayConnectionClosedEventArgs : EventArgs
    {
        /// <summary>
        /// SiloAddress of the remote silo gateway that closed.
        /// </summary>
        public SiloAddress RemoteGatewayAddresss { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayConnectionClosedEventArgs"/> class.
        /// </summary>
        /// <param name="remoteGatewayAddresss">
        /// SiloAddress of the remote silo gateway that closed.
        /// </param>        
        public GatewayConnectionClosedEventArgs(SiloAddress remoteGatewayAddresss)
        {
            this.RemoteGatewayAddresss = remoteGatewayAddresss;
        }
    }
}
