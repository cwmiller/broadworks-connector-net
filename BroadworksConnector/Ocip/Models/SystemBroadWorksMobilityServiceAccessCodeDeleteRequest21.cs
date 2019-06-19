using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a service access code from a list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1055""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceAccessCodeListName;

        [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1055")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceAccessCodeListName
        {
            get => _serviceAccessCodeListName;
            set
            {
                ServiceAccessCodeListNameSpecified = true;
                _serviceAccessCodeListName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessCodeListNameSpecified { get; set; }

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1055")]
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

        private string _serviceAccessCode;

        [XmlElement(ElementName = "serviceAccessCode", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1055")]
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
        public bool ServiceAccessCodeSpecified { get; set; }

    }
}
