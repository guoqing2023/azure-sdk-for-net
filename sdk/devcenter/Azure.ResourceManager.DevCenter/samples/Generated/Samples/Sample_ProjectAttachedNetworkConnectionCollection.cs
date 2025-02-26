// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_ProjectAttachedNetworkConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AttachedNetworksGetByProject()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/AttachedNetworks_GetByProject.json
            // this example is just showing the usage of "AttachedNetworks_GetByProject" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this ProjectAttachedNetworkConnectionResource
            ProjectAttachedNetworkConnectionCollection collection = devCenterProject.GetProjectAttachedNetworkConnections();

            // invoke the operation
            string attachedNetworkConnectionName = "network-uswest3";
            ProjectAttachedNetworkConnectionResource result = await collection.GetAsync(attachedNetworkConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AttachedNetworkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_AttachedNetworksListByProject()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/AttachedNetworks_ListByProject.json
            // this example is just showing the usage of "AttachedNetworks_ListByProject" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this ProjectAttachedNetworkConnectionResource
            ProjectAttachedNetworkConnectionCollection collection = devCenterProject.GetProjectAttachedNetworkConnections();

            // invoke the operation and iterate over the result
            await foreach (ProjectAttachedNetworkConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AttachedNetworkConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_AttachedNetworksGetByProject()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/AttachedNetworks_GetByProject.json
            // this example is just showing the usage of "AttachedNetworks_GetByProject" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this ProjectAttachedNetworkConnectionResource
            ProjectAttachedNetworkConnectionCollection collection = devCenterProject.GetProjectAttachedNetworkConnections();

            // invoke the operation
            string attachedNetworkConnectionName = "network-uswest3";
            bool result = await collection.ExistsAsync(attachedNetworkConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_AttachedNetworksGetByProject()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/AttachedNetworks_GetByProject.json
            // this example is just showing the usage of "AttachedNetworks_GetByProject" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this ProjectAttachedNetworkConnectionResource
            ProjectAttachedNetworkConnectionCollection collection = devCenterProject.GetProjectAttachedNetworkConnections();

            // invoke the operation
            string attachedNetworkConnectionName = "network-uswest3";
            NullableResponse<ProjectAttachedNetworkConnectionResource> response = await collection.GetIfExistsAsync(attachedNetworkConnectionName);
            ProjectAttachedNetworkConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AttachedNetworkConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
