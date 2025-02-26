// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServices.Samples
{
    public partial class Sample_RecoveryServicesVaultExtendedInfoResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExtendedInfoOfResource()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/GETVaultExtendedInfo.json
            // this example is just showing the usage of "VaultExtendedInfo_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultExtendedInfoResource created on azure
            // for more information of creating RecoveryServicesVaultExtendedInfoResource, please refer to the document of RecoveryServicesVaultExtendedInfoResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultExtendedInfoResourceId = RecoveryServicesVaultExtendedInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultExtendedInfoResource recoveryServicesVaultExtendedInfo = client.GetRecoveryServicesVaultExtendedInfoResource(recoveryServicesVaultExtendedInfoResourceId);

            // invoke the operation
            RecoveryServicesVaultExtendedInfoResource result = await recoveryServicesVaultExtendedInfo.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultExtendedInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PATCHExtendedInfoOfResource()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/UpdateVaultExtendedInfo.json
            // this example is just showing the usage of "VaultExtendedInfo_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultExtendedInfoResource created on azure
            // for more information of creating RecoveryServicesVaultExtendedInfoResource, please refer to the document of RecoveryServicesVaultExtendedInfoResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultExtendedInfoResourceId = RecoveryServicesVaultExtendedInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultExtendedInfoResource recoveryServicesVaultExtendedInfo = client.GetRecoveryServicesVaultExtendedInfoResource(recoveryServicesVaultExtendedInfoResourceId);

            // invoke the operation
            RecoveryServicesVaultExtendedInfoData info = new RecoveryServicesVaultExtendedInfoData();
            RecoveryServicesVaultExtendedInfoResource result = await recoveryServicesVaultExtendedInfo.UpdateAsync(info);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultExtendedInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutExtendedInfoOfResource()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/UpdateVaultExtendedInfo.json
            // this example is just showing the usage of "VaultExtendedInfo_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultExtendedInfoResource created on azure
            // for more information of creating RecoveryServicesVaultExtendedInfoResource, please refer to the document of RecoveryServicesVaultExtendedInfoResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultExtendedInfoResourceId = RecoveryServicesVaultExtendedInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultExtendedInfoResource recoveryServicesVaultExtendedInfo = client.GetRecoveryServicesVaultExtendedInfoResource(recoveryServicesVaultExtendedInfoResourceId);

            // invoke the operation
            RecoveryServicesVaultExtendedInfoData info = new RecoveryServicesVaultExtendedInfoData();
            ArmOperation<RecoveryServicesVaultExtendedInfoResource> lro = await recoveryServicesVaultExtendedInfo.CreateOrUpdateAsync(WaitUntil.Completed, info);
            RecoveryServicesVaultExtendedInfoResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultExtendedInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
