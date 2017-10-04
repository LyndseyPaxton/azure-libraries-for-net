// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConnectorMappingStates.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorMappingStates
    {
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopped")]
        Stopped,
        [EnumMember(Value = "Expiring")]
        Expiring
    }
    internal static class ConnectorMappingStatesEnumExtension
    {
        internal static string ToSerializedValue(this ConnectorMappingStates? value)
        {
            return value == null ? null : ((ConnectorMappingStates)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ConnectorMappingStates value)
        {
            switch( value )
            {
                case ConnectorMappingStates.Creating:
                    return "Creating";
                case ConnectorMappingStates.Created:
                    return "Created";
                case ConnectorMappingStates.Failed:
                    return "Failed";
                case ConnectorMappingStates.Ready:
                    return "Ready";
                case ConnectorMappingStates.Running:
                    return "Running";
                case ConnectorMappingStates.Stopped:
                    return "Stopped";
                case ConnectorMappingStates.Expiring:
                    return "Expiring";
            }
            return null;
        }

        internal static ConnectorMappingStates? ParseConnectorMappingStates(this string value)
        {
            switch( value )
            {
                case "Creating":
                    return ConnectorMappingStates.Creating;
                case "Created":
                    return ConnectorMappingStates.Created;
                case "Failed":
                    return ConnectorMappingStates.Failed;
                case "Ready":
                    return ConnectorMappingStates.Ready;
                case "Running":
                    return ConnectorMappingStates.Running;
                case "Stopped":
                    return ConnectorMappingStates.Stopped;
                case "Expiring":
                    return ConnectorMappingStates.Expiring;
            }
            return null;
        }
    }
}