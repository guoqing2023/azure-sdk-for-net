// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents metadata describing the operator of a phone number. </summary>
    public partial class OperatorDetails
    {
        /// <summary> Initializes a new instance of <see cref="OperatorDetails"/>. </summary>
        internal OperatorDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperatorDetails"/>. </summary>
        /// <param name="name"> Name of the phone operator. </param>
        /// <param name="mobileNetworkCode"> ISO 2 Mobile Network Code. </param>
        /// <param name="mobileCountryCode"> ISO 2 Mobile Country Code. </param>
        internal OperatorDetails(string name, string mobileNetworkCode, string mobileCountryCode)
        {
            Name = name;
            MobileNetworkCode = mobileNetworkCode;
            MobileCountryCode = mobileCountryCode;
        }

        /// <summary> Name of the phone operator. </summary>
        public string Name { get; }
        /// <summary> ISO 2 Mobile Network Code. </summary>
        public string MobileNetworkCode { get; }
        /// <summary> ISO 2 Mobile Country Code. </summary>
        public string MobileCountryCode { get; }
    }
}
