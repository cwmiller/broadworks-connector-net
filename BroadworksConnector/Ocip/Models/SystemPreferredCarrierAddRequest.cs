using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a carrier to the system.
    /// More than one carrier may be assigned to each country code.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:319""}]")]
    public class SystemPreferredCarrierAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool CarrierSpecified { get; set; }

        private string _cic;

        [XmlElement(ElementName = "cic", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool CicSpecified { get; set; }

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool CountryCodeSpecified { get; set; }

        private bool _isIntraLata;

        [XmlElement(ElementName = "isIntraLata", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool IsIntraLataSpecified { get; set; }

        private bool _isInterLata;

        [XmlElement(ElementName = "isInterLata", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool IsInterLataSpecified { get; set; }

        private bool _isInternational;

        [XmlElement(ElementName = "isInternational", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:319")]
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
        protected bool IsInternationalSpecified { get; set; }

    }
}
