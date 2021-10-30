using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system outgoing calling plan call type mapping.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:876""}]")]
    public class SystemOutgoingCallingPlanCallTypeAddMappingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:876")]
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

        private string _digitMap;

        [XmlElement(ElementName = "digitMap", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:876")]
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

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:876")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType CallType
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

    }
}
