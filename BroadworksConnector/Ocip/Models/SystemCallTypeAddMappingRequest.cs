using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system call type mapping.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following element is used only in AS mode:
    /// ignoreASEmergencyRoute
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5259""}]")]
    public class SystemCallTypeAddMappingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5259")]
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

        protected string _digitMap;

        [XmlElement(ElementName = "digitMap", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5259")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DigitMap
        {
            get => _digitMap;
            set
            {
                DigitMapSpecified = true;
                _digitMap = value;
            }
        }

        [XmlIgnore]
        protected bool DigitMapSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemCallType _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5259")]
        public BroadWorksConnector.Ocip.Models.SystemCallType CallType
        {
            get => _callType;
            set
            {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        protected bool CallTypeSpecified { get; set; }

        protected bool _ignoreASEmergencyRoute;

        [XmlElement(ElementName = "ignoreASEmergencyRoute", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5259")]
        public bool IgnoreASEmergencyRoute
        {
            get => _ignoreASEmergencyRoute;
            set
            {
                IgnoreASEmergencyRouteSpecified = true;
                _ignoreASEmergencyRoute = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreASEmergencyRouteSpecified { get; set; }

    }
}
