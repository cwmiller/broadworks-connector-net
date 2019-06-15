using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request for an agent to login or logout of one or more Call Centers.
    /// Contains a list specifing the desired login status of one or more call centers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserCallCenterModifyRequest17sp4
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallCenterModifyRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterModifyAvailabilityListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> _callCenterAvailability;

        [XmlElement(ElementName = "callCenterAvailability", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> CallCenterAvailability {
            get => _callCenterAvailability;
            set {
                CallCenterAvailabilitySpecified = true;
                _callCenterAvailability = value;
            }
        }

        [XmlIgnore]
        public bool CallCenterAvailabilitySpecified { get; set; }
        
    }
}
