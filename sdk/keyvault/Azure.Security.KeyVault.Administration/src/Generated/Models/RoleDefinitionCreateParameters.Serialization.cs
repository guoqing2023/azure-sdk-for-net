// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Security.KeyVault.Administration;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleDefinitionCreateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }
    }
}
