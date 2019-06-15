using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add users to the BroadWorks Receptionist - Enterprise monitored user list.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksReceptionistEnterpriseAddUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _monitoredUserId;

        [XmlElement(ElementName = "monitoredUserId", IsNullable = false, Namespace = "")]
        public List<string> MonitoredUserId {
            get => _monitoredUserId;
            set {
                MonitoredUserIdSpecified = true;
                _monitoredUserId = value;
            }
        }

        [XmlIgnore]
        public bool MonitoredUserIdSpecified { get; set; }
        
    }
}
