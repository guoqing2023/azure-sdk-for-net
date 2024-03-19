// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.IoT.Hub.Service;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class JobResponse
    {
        internal static JobResponse DeserializeJobResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobId = default;
            string queryCondition = default;
            DateTimeOffset? createdTime = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            long? maxExecutionTimeInSeconds = default;
            JobResponseType? type = default;
            CloudToDeviceMethodRequest cloudToDeviceMethod = default;
            TwinData updateTwin = default;
            JobResponseStatus? status = default;
            string failureReason = default;
            string statusMessage = default;
            DeviceJobStatistics deviceJobStatistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryCondition"u8))
                {
                    queryCondition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maxExecutionTimeInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxExecutionTimeInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new JobResponseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMethod = CloudToDeviceMethodRequest.DeserializeCloudToDeviceMethodRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("updateTwin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTwin = TwinData.DeserializeTwinData(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new JobResponseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"u8))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceJobStatistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceJobStatistics = DeviceJobStatistics.DeserializeDeviceJobStatistics(property.Value);
                    continue;
                }
            }
            return new JobResponse(
                jobId,
                queryCondition,
                createdTime,
                startTime,
                endTime,
                maxExecutionTimeInSeconds,
                type,
                cloudToDeviceMethod,
                updateTwin,
                status,
                failureReason,
                statusMessage,
                deviceJobStatistics);
        }
    }
}
