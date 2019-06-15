using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Clear a user's call logs associated with Basic Call Logs and Enhanced
    /// Call Logs features. The calls logs are deleted from both Basic Call Logs
    /// and Enhanced Call Logs if both features are assigned.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallLogsClearRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _deleteAllCallLogs;

        [XmlElement(ElementName = "deleteAllCallLogs", IsNullable = false, Namespace = "")]
        public bool DeleteAllCallLogs {
            get => _deleteAllCallLogs;
            set {
                DeleteAllCallLogsSpecified = true;
                _deleteAllCallLogs = value;
            }
        }

        [XmlIgnore]
        public bool DeleteAllCallLogsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs _deleteSpecifiedCallLogs;

        [XmlElement(ElementName = "deleteSpecifiedCallLogs", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs DeleteSpecifiedCallLogs {
            get => _deleteSpecifiedCallLogs;
            set {
                DeleteSpecifiedCallLogsSpecified = true;
                _deleteSpecifiedCallLogs = value;
            }
        }

        [XmlIgnore]
        public bool DeleteSpecifiedCallLogsSpecified { get; set; }
        
    }
}
