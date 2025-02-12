// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Extensions;

    /// <summary>The type used for update operations of the Contact.</summary>
    public partial class ContactUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.ContactUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ContactUpdate" /> instance.</summary>
        public ContactUpdate()
        {

        }
    }
    /// The type used for update operations of the Contact.
    public partial interface IContactUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateTags Tag { get; set; }

    }
    /// The type used for update operations of the Contact.
    internal partial interface IContactUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20221201Preview.IContactUpdateTags Tag { get; set; }

    }
}