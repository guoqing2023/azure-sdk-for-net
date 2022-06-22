// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VnetRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartAddress))
            {
                writer.WritePropertyName("startAddress");
                writer.WriteStringValue(StartAddress);
            }
            if (Optional.IsDefined(EndAddress))
            {
                writer.WritePropertyName("endAddress");
                writer.WriteStringValue(EndAddress);
            }
            if (Optional.IsDefined(RouteType))
            {
                writer.WritePropertyName("routeType");
                writer.WriteStringValue(RouteType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetRoute DeserializeVnetRoute(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> startAddress = default;
            Optional<string> endAddress = default;
            Optional<RouteType> routeType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startAddress"))
                        {
                            startAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endAddress"))
                        {
                            endAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routeType = new RouteType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetRoute(id, name, type, systemData.Value, kind.Value, startAddress.Value, endAddress.Value, Optional.ToNullable(routeType));
        }
    }
}
