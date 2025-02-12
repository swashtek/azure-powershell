// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Savings plan patch request</summary>
    public partial class SavingsPlanUpdateRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal
    {

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertiesDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertiesManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertiesResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertiesSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertiesTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="AppliedScopeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties _appliedScopeProperty;

        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.AppliedScopeProperties()); set => this._appliedScopeProperty = value; }

        /// <summary>Backing field for <see cref="AppliedScopeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? _appliedScopeType;

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get => this._appliedScopeType; set => this._appliedScopeType = value; }

        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).BillingPlan; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).BillingPlan = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan)""); }

        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string BillingScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).BillingScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).BillingScopeId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public double? CommitmentAmount { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentAmount; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentAmount = value ?? default(double); }

        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string CommitmentCurrencyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentCurrencyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentCurrencyCode = value ?? null; }

        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentGrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).CommitmentGrain = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain)""); }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>DateTime of the savings plan starts providing benefit from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public global::System.DateTime? EffectiveDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).EffectiveDateTime; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.AppliedScopeProperties()); set { {_appliedScopeProperty = value;} } }

        /// <summary>Internal Acessors for Commitment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ICommitment Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.Commitment { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Commitment; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Commitment = value; }

        /// <summary>Internal Acessors for EffectiveDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.EffectiveDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).EffectiveDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).EffectiveDateTime = value; }

        /// <summary>Internal Acessors for PurchaseProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPurchaseRequestProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.PurchaseProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchasePropertiesProperties; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchasePropertiesProperties = value; }

        /// <summary>Internal Acessors for PurchasePropertySku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.PurchasePropertySku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchasePropertySku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchasePropertySku = value; }

        /// <summary>Internal Acessors for RenewPropertiesPurchasePropertiesAppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.RenewPropertiesPurchasePropertiesAppliedScopeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopeProperty = value; }

        /// <summary>Internal Acessors for RenewProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.RenewProperty { get => (this._renewProperty = this._renewProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.RenewProperties()); set { {_renewProperty = value;} } }

        /// <summary>Internal Acessors for RenewPropertyPurchaseProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPurchaseRequest Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.RenewPropertyPurchaseProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchaseProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).PurchaseProperty = value; }

        /// <summary>Backing field for <see cref="Renew" /> property.</summary>
        private bool? _renew;

        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public bool? Renew { get => this._renew; set => this._renew = value; }

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesAppliedScopePropertiesDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyDisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesAppliedScopePropertiesManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesAppliedScopePropertiesResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesAppliedScopePropertiesSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertySubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertySubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesAppliedScopePropertiesTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopePropertyTenantId = value ?? null; }

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? RenewPropertiesPurchasePropertiesAppliedScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).AppliedScopeType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType)""); }

        /// <summary>Friendly name of the savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string RenewPropertiesPurchasePropertiesDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).DisplayName = value ?? null; }

        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public bool? RenewPropertiesPurchasePropertiesRenew { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Renew; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Renew = value ?? default(bool); }

        /// <summary>Backing field for <see cref="RenewProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties _renewProperty;

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties RenewProperty { get => (this._renewProperty = this._renewProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.RenewProperties()); set => this._renewProperty = value; }

        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).SkuName = value ?? null; }

        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Term; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewPropertiesInternal)RenewProperty).Term = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term)""); }

        /// <summary>Creates an new <see cref="SavingsPlanUpdateRequestProperties" /> instance.</summary>
        public SavingsPlanUpdateRequestProperties()
        {

        }
    }
    /// Savings plan patch request
    public partial interface ISavingsPlanUpdateRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertiesDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertiesManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertiesResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertiesSubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the benefit is applied.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertiesTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing the benefit",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amount",
        PossibleTypes = new [] { typeof(double) })]
        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ISO 4217 3-letter currency code for the currency used by this purchase record.",
        SerializedName = @"currencyCode",
        PossibleTypes = new [] { typeof(string) })]
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Commitment grain.",
        SerializedName = @"grain",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>DateTime of the savings plan starts providing benefit from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateTime of the savings plan starts providing benefit from.",
        SerializedName = @"effectiveDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EffectiveDateTime { get;  }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new benefit on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Renew { get; set; }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesSubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the benefit is applied.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? RenewPropertiesPurchasePropertiesAppliedScopeType { get; set; }
        /// <summary>Friendly name of the savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the savings plan",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RenewPropertiesPurchasePropertiesDisplayName { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new benefit on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RenewPropertiesPurchasePropertiesRenew { get; set; }
        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the SKU to be applied",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent benefit term in ISO 8601 format.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
    /// Savings plan patch request
    internal partial interface ISavingsPlanUpdateRequestPropertiesInternal

    {
        /// <summary>Display name</summary>
        string AppliedScopePropertiesDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertiesManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertiesResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertiesSubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        string AppliedScopePropertiesTenantId { get; set; }
        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        string BillingScopeId { get; set; }
        /// <summary>Commitment towards the benefit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ICommitment Commitment { get; set; }

        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Display name</summary>
        string DisplayName { get; set; }
        /// <summary>DateTime of the savings plan starts providing benefit from.</summary>
        global::System.DateTime? EffectiveDateTime { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPurchaseRequestProperties PurchaseProperty { get; set; }
        /// <summary>The SKU to be applied for this resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku PurchasePropertySku { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        bool? Renew { get; set; }
        /// <summary>Display name</summary>
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesSubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        string RenewPropertiesPurchasePropertiesAppliedScopePropertiesTenantId { get; set; }
        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties RenewPropertiesPurchasePropertiesAppliedScopeProperty { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? RenewPropertiesPurchasePropertiesAppliedScopeType { get; set; }
        /// <summary>Friendly name of the savings plan</summary>
        string RenewPropertiesPurchasePropertiesDisplayName { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        bool? RenewPropertiesPurchasePropertiesRenew { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties RenewProperty { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPurchaseRequest RenewPropertyPurchaseProperty { get; set; }
        /// <summary>Name of the SKU to be applied</summary>
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
}