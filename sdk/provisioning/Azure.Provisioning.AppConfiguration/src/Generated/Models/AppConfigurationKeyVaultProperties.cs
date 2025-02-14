// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// Settings concerning key vault encryption for a configuration store.
/// </summary>
public partial class AppConfigurationKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// The URI of the key vault key used to encrypt data.
    /// </summary>
    public BicepValue<string> KeyIdentifier 
    {
        get { Initialize(); return _keyIdentifier!; }
        set { Initialize(); _keyIdentifier!.Assign(value); }
    }
    private BicepValue<string>? _keyIdentifier;

    /// <summary>
    /// The client id of the identity which will be used to access key vault.
    /// </summary>
    public BicepValue<string> IdentityClientId 
    {
        get { Initialize(); return _identityClientId!; }
        set { Initialize(); _identityClientId!.Assign(value); }
    }
    private BicepValue<string>? _identityClientId;

    /// <summary>
    /// Creates a new AppConfigurationKeyVaultProperties.
    /// </summary>
    public AppConfigurationKeyVaultProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// AppConfigurationKeyVaultProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _keyIdentifier = DefineProperty<string>("KeyIdentifier", ["keyIdentifier"]);
        _identityClientId = DefineProperty<string>("IdentityClientId", ["identityClientId"]);
    }
}
