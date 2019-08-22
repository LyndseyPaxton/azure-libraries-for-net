// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VPN client connection health detail.
    /// </summary>
    public partial class VpnClientConnectionHealthDetail
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientConnectionHealthDetail
        /// class.
        /// </summary>
        public VpnClientConnectionHealthDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnClientConnectionHealthDetail
        /// class.
        /// </summary>
        /// <param name="vpnConnectionId">The vpn client Id.</param>
        /// <param name="vpnConnectionDuration">The duration time of a
        /// connected vpn client.</param>
        /// <param name="vpnConnectionTime">The start time of a connected vpn
        /// client.</param>
        /// <param name="publicIpAddress">The public Ip of a connected vpn
        /// client.</param>
        /// <param name="privateIpAddress">The assigned private Ip of a
        /// connected vpn client.</param>
        /// <param name="vpnUserName">The user name of a connected vpn
        /// client.</param>
        /// <param name="maxBandwidth">The max band width.</param>
        /// <param name="egressPacketsTransferred">The egress packets per
        /// second.</param>
        /// <param name="egressBytesTransferred">The egress bytes per
        /// second.</param>
        /// <param name="ingressPacketsTransferred">The ingress packets per
        /// second.</param>
        /// <param name="ingressBytesTransferred">The ingress bytes per
        /// second.</param>
        /// <param name="maxPacketsPerSecond">The max packets transferred per
        /// second.</param>
        public VpnClientConnectionHealthDetail(string vpnConnectionId = default(string), long? vpnConnectionDuration = default(long?), string vpnConnectionTime = default(string), string publicIpAddress = default(string), string privateIpAddress = default(string), string vpnUserName = default(string), long? maxBandwidth = default(long?), long? egressPacketsTransferred = default(long?), long? egressBytesTransferred = default(long?), long? ingressPacketsTransferred = default(long?), long? ingressBytesTransferred = default(long?), long? maxPacketsPerSecond = default(long?))
        {
            VpnConnectionId = vpnConnectionId;
            VpnConnectionDuration = vpnConnectionDuration;
            VpnConnectionTime = vpnConnectionTime;
            PublicIpAddress = publicIpAddress;
            PrivateIpAddress = privateIpAddress;
            VpnUserName = vpnUserName;
            MaxBandwidth = maxBandwidth;
            EgressPacketsTransferred = egressPacketsTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            IngressPacketsTransferred = ingressPacketsTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            MaxPacketsPerSecond = maxPacketsPerSecond;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the vpn client Id.
        /// </summary>
        [JsonProperty(PropertyName = "vpnConnectionId")]
        public string VpnConnectionId { get; private set; }

        /// <summary>
        /// Gets the duration time of a connected vpn client.
        /// </summary>
        [JsonProperty(PropertyName = "vpnConnectionDuration")]
        public long? VpnConnectionDuration { get; private set; }

        /// <summary>
        /// Gets the start time of a connected vpn client.
        /// </summary>
        [JsonProperty(PropertyName = "vpnConnectionTime")]
        public string VpnConnectionTime { get; private set; }

        /// <summary>
        /// Gets the public Ip of a connected vpn client.
        /// </summary>
        [JsonProperty(PropertyName = "publicIpAddress")]
        public string PublicIpAddress { get; private set; }

        /// <summary>
        /// Gets the assigned private Ip of a connected vpn client.
        /// </summary>
        [JsonProperty(PropertyName = "privateIpAddress")]
        public string PrivateIpAddress { get; private set; }

        /// <summary>
        /// Gets the user name of a connected vpn client.
        /// </summary>
        [JsonProperty(PropertyName = "vpnUserName")]
        public string VpnUserName { get; private set; }

        /// <summary>
        /// Gets the max band width.
        /// </summary>
        [JsonProperty(PropertyName = "maxBandwidth")]
        public long? MaxBandwidth { get; private set; }

        /// <summary>
        /// Gets the egress packets per second.
        /// </summary>
        [JsonProperty(PropertyName = "egressPacketsTransferred")]
        public long? EgressPacketsTransferred { get; private set; }

        /// <summary>
        /// Gets the egress bytes per second.
        /// </summary>
        [JsonProperty(PropertyName = "egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress packets per second.
        /// </summary>
        [JsonProperty(PropertyName = "ingressPacketsTransferred")]
        public long? IngressPacketsTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress bytes per second.
        /// </summary>
        [JsonProperty(PropertyName = "ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the max packets transferred per second.
        /// </summary>
        [JsonProperty(PropertyName = "maxPacketsPerSecond")]
        public long? MaxPacketsPerSecond { get; private set; }

    }
}