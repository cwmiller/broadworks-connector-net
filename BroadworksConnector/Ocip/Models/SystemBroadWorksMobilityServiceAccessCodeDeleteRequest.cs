using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a system service access code.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21227""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21227")]
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

        protected string _serviceAccessCode;

        [XmlElement(ElementName = "serviceAccessCode", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21227")]
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

    }
}
