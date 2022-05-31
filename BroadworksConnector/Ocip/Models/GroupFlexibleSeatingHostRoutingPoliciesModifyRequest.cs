using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a flexible seating host’s routing policies
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:346""}]")]
    public class GroupFlexibleSeatingHostRoutingPoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:346")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool _allowEmergencyCalls;

        [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:346")]
        public bool AllowEmergencyCalls
        {
            get => _allowEmergencyCalls;
            set
            {
                AllowEmergencyCallsSpecified = true;
                _allowEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowEmergencyCallsSpecified { get; set; }

        protected bool _allowCallsToVoicePortal;

        [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:346")]
        public bool AllowCallsToVoicePortal
        {
            get => _allowCallsToVoicePortal;
            set
            {
                AllowCallsToVoicePortalSpecified = true;
                _allowCallsToVoicePortal = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallsToVoicePortalSpecified { get; set; }

    }
}
