using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add the country code preferred carriers for a service provider or enterprise. For each
    /// combination of service provider and country code, you can assign an intra-lata, inter-lata,
    /// and international carrier. Each of the three types of carriers is optional.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Note: At the system level, more than one carrier may be assigned to each country code.
    /// At the service provider level, you must choose from the carriers assigned at the system level.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:116""}]")]
    public class ServiceProviderPreferredCarrierAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:116")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:116")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }

        private string _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:116")]
        [MinLength(1)]
        [MaxLength(80)]
        public string IntraLataCarrier
        {
            get => _intraLataCarrier;
            set
            {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool IntraLataCarrierSpecified { get; set; }

        private string _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:116")]
        [MinLength(1)]
        [MaxLength(80)]
        public string InterLataCarrier
        {
            get => _interLataCarrier;
            set
            {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InterLataCarrierSpecified { get; set; }

        private string _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:116")]
        [MinLength(1)]
        [MaxLength(80)]
        public string InternationalCarrier
        {
            get => _internationalCarrier;
            set
            {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InternationalCarrierSpecified { get; set; }

    }
}
