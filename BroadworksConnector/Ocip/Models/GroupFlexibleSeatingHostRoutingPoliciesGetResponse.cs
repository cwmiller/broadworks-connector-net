using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFlexibleSeatingHostRoutingPoliciesGetRequest.
    /// <see cref="GroupFlexibleSeatingHostRoutingPoliciesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:404""}]")]
    public class GroupFlexibleSeatingHostRoutingPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _allowEmergencyCalls;

        [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:404")]
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

        private bool _allowCallsToVoicePortal;

        [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:404")]
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
