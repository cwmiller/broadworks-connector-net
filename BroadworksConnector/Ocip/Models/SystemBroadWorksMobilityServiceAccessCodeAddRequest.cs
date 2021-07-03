using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system service access code.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeAddRequest21.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeAddRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20474""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceAccessCode;

        [XmlElement(ElementName = "serviceAccessCode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20474")]
        [MinLength(1)]
        [MaxLength(10)]
        public string ServiceAccessCode
        {
            get => _serviceAccessCode;
            set
            {
                ServiceAccessCodeSpecified = true;
                _serviceAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessCodeSpecified { get; set; }

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20474")]
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

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20474")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

    }
}
