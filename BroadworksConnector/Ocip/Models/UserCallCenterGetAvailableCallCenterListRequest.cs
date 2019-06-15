using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This request gets a list of all call centers which the user can be assigned to as an agent.
    /// Some of the call centers may already have the user as an agent.  It is the clients
    /// responsibility to discard the call centers that the user is already an agent of.
    /// The response is either a UserCallCenterGetAvailableCallCenterListResponse or an ErrorResponse.
        /// <see cref="UserCallCenterGetAvailableCallCenterListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetAvailableCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
