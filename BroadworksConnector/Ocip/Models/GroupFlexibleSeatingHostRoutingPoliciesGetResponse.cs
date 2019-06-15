using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFlexibleSeatingHostRoutingPoliciesGetRequest.
        /// <see cref="GroupFlexibleSeatingHostRoutingPoliciesGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFlexibleSeatingHostRoutingPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _allowEmergencyCalls;

        [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false, Namespace = "")]
        public bool AllowEmergencyCalls {
            get => _allowEmergencyCalls;
            set {
                AllowEmergencyCallsSpecified = true;
                _allowEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool AllowEmergencyCallsSpecified { get; set; }
        
        private bool _allowCallsToVoicePortal;

        [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false, Namespace = "")]
        public bool AllowCallsToVoicePortal {
            get => _allowCallsToVoicePortal;
            set {
                AllowCallsToVoicePortalSpecified = true;
                _allowCallsToVoicePortal = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallsToVoicePortalSpecified { get; set; }
        
    }
}
