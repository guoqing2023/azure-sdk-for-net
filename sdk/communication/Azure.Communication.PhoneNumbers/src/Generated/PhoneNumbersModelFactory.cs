// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Model factory for models. </summary>
    public static partial class PhoneNumbersModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberAreaCode"/>. </summary>
        /// <param name="areaCode"> An area code. </param>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberAreaCode"/> instance for mocking. </returns>
        public static PhoneNumberAreaCode PhoneNumberAreaCode(string areaCode = null)
        {
            return new PhoneNumberAreaCode(areaCode);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberCountry"/>. </summary>
        /// <param name="localizedName"> Represents the name of the country. </param>
        /// <param name="countryCode"> Represents the abbreviated name of the country. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localizedName"/> or <paramref name="countryCode"/> is null. </exception>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberCountry"/> instance for mocking. </returns>
        public static PhoneNumberCountry PhoneNumberCountry(string localizedName = null, string countryCode = null)
        {
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }

            return new PhoneNumberCountry(localizedName, countryCode);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberLocality"/>. </summary>
        /// <param name="localizedName"> Represents the localized name of the locality. </param>
        /// <param name="administrativeDivision"> Represents an administrative division. e.g. state or province. </param>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberLocality"/> instance for mocking. </returns>
        public static PhoneNumberLocality PhoneNumberLocality(string localizedName = null, PhoneNumberAdministrativeDivision administrativeDivision = null)
        {
            return new PhoneNumberLocality(localizedName, administrativeDivision);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberAdministrativeDivision"/>. </summary>
        /// <param name="localizedName"> Represents the localized name of the administrative division of the locality. e.g. state or province localized name. </param>
        /// <param name="abbreviatedName"> Represents the abbreviated name of the administrative division of the locality. e.g. state or province abbreviation such as WA (Washington). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localizedName"/> or <paramref name="abbreviatedName"/> is null. </exception>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberAdministrativeDivision"/> instance for mocking. </returns>
        public static PhoneNumberAdministrativeDivision PhoneNumberAdministrativeDivision(string localizedName = null, string abbreviatedName = null)
        {
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }
            if (abbreviatedName == null)
            {
                throw new ArgumentNullException(nameof(abbreviatedName));
            }

            return new PhoneNumberAdministrativeDivision(localizedName, abbreviatedName);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberOffering"/>. </summary>
        /// <param name="phoneNumberType"> Represents the number type of the offering. </param>
        /// <param name="assignmentType"> Represents the assignment type of the offering. </param>
        /// <param name="availableCapabilities"> Capabilities of a phone number. </param>
        /// <param name="cost"> The incurred cost for a single phone number. </param>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberOffering"/> instance for mocking. </returns>
        public static PhoneNumberOffering PhoneNumberOffering(PhoneNumberType? phoneNumberType = null, PhoneNumberAssignmentType? assignmentType = null, PhoneNumberCapabilities availableCapabilities = null, PhoneNumberCost cost = null)
        {
            return new PhoneNumberOffering(phoneNumberType, assignmentType, availableCapabilities, cost);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberCost"/>. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="isoCurrencySymbol"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="isoCurrencySymbol"/> is null. </exception>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberCost"/> instance for mocking. </returns>
        public static PhoneNumberCost PhoneNumberCost(double amount = default, string isoCurrencySymbol = null, BillingFrequency billingFrequency = default)
        {
            if (isoCurrencySymbol == null)
            {
                throw new ArgumentNullException(nameof(isoCurrencySymbol));
            }

            return new PhoneNumberCost(amount, isoCurrencySymbol, billingFrequency);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.PhoneNumberSearchResult"/>. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="phoneNumbers"> The phone numbers that are available. Can be fewer than the desired search quantity. </param>
        /// <param name="phoneNumberType"> The phone number's type, e.g. geographic, or tollFree. </param>
        /// <param name="assignmentType"> Phone number's assignment type. </param>
        /// <param name="capabilities"> Capabilities of a phone number. </param>
        /// <param name="cost"> The incurred cost for a single phone number. </param>
        /// <param name="searchExpiresOn"> The date that this search result expires and phone numbers are no longer on hold. A search result expires in less than 15min, e.g. 2020-11-19T16:31:49.048Z. </param>
        /// <param name="errorCode"> The error code of the search. </param>
        /// <param name="error"> Mapping Error Messages to Codes. </param>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberSearchResult"/> instance for mocking. </returns>
        public static PhoneNumberSearchResult PhoneNumberSearchResult(string searchId = null, IEnumerable<string> phoneNumbers = null, PhoneNumberType phoneNumberType = default, PhoneNumberAssignmentType assignmentType = default, PhoneNumberCapabilities capabilities = null, PhoneNumberCost cost = null, DateTimeOffset searchExpiresOn = default, int? errorCode = null, PhoneNumberSearchResultError? error = null)
        {
            phoneNumbers ??= new List<string>();

            return new PhoneNumberSearchResult(
                searchId,
                phoneNumbers?.ToList(),
                phoneNumberType,
                assignmentType,
                capabilities,
                cost,
                searchExpiresOn,
                errorCode,
                error);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.OperatorInformationResult"/>. </summary>
        /// <param name="values">
        /// Results of a search.
        /// This array will have one entry per requested phone number which will contain the relevant operator information.
        /// </param>
        /// <returns> A new <see cref="PhoneNumbers.OperatorInformationResult"/> instance for mocking. </returns>
        public static OperatorInformationResult OperatorInformationResult(IEnumerable<OperatorInformation> values = null)
        {
            values ??= new List<OperatorInformation>();

            return new OperatorInformationResult(values?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.OperatorInformation"/>. </summary>
        /// <param name="phoneNumber"> E.164 formatted string representation of the phone number. </param>
        /// <param name="nationalFormat"> National format of the phone number. </param>
        /// <param name="internationalFormat"> International format of the phone number. </param>
        /// <param name="isoCountryCode"> ISO 3166-1 two character ('alpha-2') code associated with the phone number. </param>
        /// <param name="numberType"> Type of service associated with the phone number. </param>
        /// <param name="operatorDetails"> Represents metadata describing the operator of a phone number. </param>
        /// <returns> A new <see cref="PhoneNumbers.OperatorInformation"/> instance for mocking. </returns>
        public static OperatorInformation OperatorInformation(string phoneNumber = null, string nationalFormat = null, string internationalFormat = null, string isoCountryCode = null, OperatorNumberType? numberType = null, OperatorDetails operatorDetails = null)
        {
            return new OperatorInformation(
                phoneNumber,
                nationalFormat,
                internationalFormat,
                isoCountryCode,
                numberType,
                operatorDetails);
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumbers.OperatorDetails"/>. </summary>
        /// <param name="name"> Name of the phone operator. </param>
        /// <param name="mobileNetworkCode"> Mobile Network Code, 2 or 3 decimal digits that identify mobile networks within a country. </param>
        /// <param name="mobileCountryCode"> Mobile Country Code, 3 decimal digits that identify a country. </param>
        /// <returns> A new <see cref="PhoneNumbers.OperatorDetails"/> instance for mocking. </returns>
        public static OperatorDetails OperatorDetails(string name = null, string mobileNetworkCode = null, string mobileCountryCode = null)
        {
            return new OperatorDetails(name, mobileNetworkCode, mobileCountryCode);
        }
    }
}
