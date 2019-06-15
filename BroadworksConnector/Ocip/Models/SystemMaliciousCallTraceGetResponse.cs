using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemMaliciousCallTraceGetRequest.
    /// The response contains the Malicious Call Trace system parameters and the list of users
    /// that use the Malicious Call Trace feature.
    /// 
    /// The column headings are "Service Provider Id",
    /// "Group Id", "User Id", "Last Name", "First Name", "Phone Number", "Trace Type", "Status",
    /// "Hiragana Last Name" and "Hiragana First Name", "Extension", "Department", "Email Address".
        /// <see cref="SystemMaliciousCallTraceGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMaliciousCallTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        public bool PlayMCTWarningAnnouncement {
            get => _playMCTWarningAnnouncement;
            set {
                PlayMCTWarningAnnouncementSpecified = true;
                _playMCTWarningAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool PlayMCTWarningAnnouncementSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable {
            get => _userTable;
            set {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        public bool UserTableSpecified { get; set; }
        
    }
}
