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
        /// Remaining number of connected gateways.
        /// </summary>
        public int RemainingGatewaysCount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayConnectionClosedEventArgs"/> class.
        /// </summary>
        /// <param name="remoteGatewayAddresss">
        /// SiloAddress of the remote silo gateway that closed.
        /// </param>
        /// <param name="remainingGatewaysCount">
        /// Remaining number of connected gateways
        /// </param>        
        public GatewayConnectionClosedEventArgs(SiloAddress remoteGatewayAddresss, int remainingGatewaysCount)
        {
            this.RemoteGatewayAddresss = remoteGatewayAddresss;
            this.RemainingGatewaysCount = remainingGatewaysCount;
        }
    }
}
