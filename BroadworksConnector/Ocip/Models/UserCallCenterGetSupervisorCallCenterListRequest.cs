using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of call centers the user is assigned to as a supervisor.
    /// The response is either a UserCallCenterGetSupervisorCallCenterListResponse or an
    /// ErrorResponse.
        /// <see cref="UserCallCenterGetSupervisorCallCenterListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetSupervisorCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        public string SupervisorUserId {
            get => _supervisorUserId;
            set {
                SupervisorUserIdSpecified = true;
                _supervisorUserId = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdSpecified { get; set; }
        
    }
}
