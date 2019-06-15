using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCommunicationBarringUserControlGetRequest.
    /// Identifies the profiles available to the user and which one if any
    /// is active as well as the lockout status.
    /// Contains a table with column headings: "Name", "Code", "Activated" and "Primary".
        /// <see cref="UserCommunicationBarringUserControlGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCommunicationBarringUserControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _lockoutStatus;

        [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
        public bool LockoutStatus {
            get => _lockoutStatus;
            set {
                LockoutStatusSpecified = true;
                _lockoutStatus = value;
            }
        }

        [XmlIgnore]
        public bool LockoutStatusSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable {
            get => _profileTable;
            set {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        public bool ProfileTableSpecified { get; set; }
        
    }
}
