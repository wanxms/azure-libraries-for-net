// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for OnboardingStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<OnboardingStatus>))]
    public class OnboardingStatus : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<OnboardingStatus>
    {
        public static readonly OnboardingStatus Onboarded = Parse("onboarded");
        public static readonly OnboardingStatus NotOnboarded = Parse("notOnboarded");
        public static readonly OnboardingStatus Unknown = Parse("unknown");
    }
}
