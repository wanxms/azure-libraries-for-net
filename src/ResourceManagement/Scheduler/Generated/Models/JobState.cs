// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Microsoft.Azure.Management.Scheduler.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class JobStateEnumExtension
    {
        internal static string ToSerializedValue(this JobState? value)  =>
            value == null ? null : ((JobState)value).ToSerializedValue();

        internal static string ToSerializedValue(this JobState value)
        {
            switch( value )
            {
                case JobState.Enabled:
                    return "Enabled";
                case JobState.Disabled:
                    return "Disabled";
                case JobState.Faulted:
                    return "Faulted";
                case JobState.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static JobState? ParseJobState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return JobState.Enabled;
                case "Disabled":
                    return JobState.Disabled;
                case "Faulted":
                    return JobState.Faulted;
                case "Completed":
                    return JobState.Completed;
            }
            return null;
        }
    }
}