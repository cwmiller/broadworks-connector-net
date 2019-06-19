using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the attributes of a carrier.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// An ErrorResponse is returned if countryCode modification is attempted while the carrier is assigned to a service provider.
    /// An ErrorResponse is returned if an attempt to set isIntraLata to false is made while the carrier is used as an intra-LATA carrier.
    /// An ErrorResponse is returned if an attempt to set isInternational to false is made while the carrier is used as an international carrier.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:515""}]")]
    public class SystemPreferredCarrierModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Carrier
        {
            get => _carrier;
            set
            {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        public bool CarrierSpecified { get; set; }

        private string _cic;

        [XmlElement(ElementName = "cic", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
        [MinLength(1)]
        [MaxLength(6)]
        public string Cic
        {
            get => _cic;
            set
            {
                CicSpecified = true;
                _cic = value;
            }
        }

        [XmlIgnore]
        public bool CicSpecified { get; set; }

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
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

        private bool _isIntraLata;

        [XmlElement(ElementName = "isIntraLata", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
        public bool IsIntraLata
        {
            get => _isIntraLata;
            set
            {
                IsIntraLataSpecified = true;
                _isIntraLata = value;
            }
        }

        [XmlIgnore]
        public bool IsIntraLataSpecified { get; set; }

        private bool _isInterLata;

        [XmlElement(ElementName = "isInterLata", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
        public bool IsInterLata
        {
            get => _isInterLata;
            set
            {
                IsInterLataSpecified = true;
                _isInterLata = value;
            }
        }

        [XmlIgnore]
        public bool IsInterLataSpecified { get; set; }

        private bool _isInternational;

        [XmlElement(ElementName = "isInternational", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:515")]
        public bool IsInternational
        {
            get => _isInternational;
            set
            {
                IsInternationalSpecified = true;
                _isInternational = value;
            }
        }

        [XmlIgnore]
        public bool IsInternationalSpecified { get; set; }

    }
}
