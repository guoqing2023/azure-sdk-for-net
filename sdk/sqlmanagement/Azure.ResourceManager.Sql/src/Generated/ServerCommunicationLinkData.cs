// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServerCommunicationLink data model. </summary>
    public partial class ServerCommunicationLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of ServerCommunicationLinkData. </summary>
        public ServerCommunicationLinkData()
        {
        }

        /// <summary> Initializes a new instance of ServerCommunicationLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Communication link location. </param>
        /// <param name="kind"> Communication link kind.  This property is used for Azure Portal metadata. </param>
        /// <param name="state"> The state. </param>
        /// <param name="partnerServer"> The name of the partner server. </param>
        internal ServerCommunicationLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, string state, string partnerServer) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            State = state;
            PartnerServer = partnerServer;
        }

        /// <summary> Communication link location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Communication link kind.  This property is used for Azure Portal metadata. </summary>
        public string Kind { get; }
        /// <summary> The state. </summary>
        public string State { get; }
        /// <summary> The name of the partner server. </summary>
        public string PartnerServer { get; set; }
    }
}
