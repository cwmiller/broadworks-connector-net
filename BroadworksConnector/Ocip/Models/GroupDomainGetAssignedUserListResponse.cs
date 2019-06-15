using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDomainGetAssignedUserListRequest.
    /// The table columns are: "User Id", "Last Name", "First Name", "Department", "Phone Number", "Email Address",
    /// "Service Provider Id", "Group Id", "Hiragana Last Name" and "Hiragana First Name", "Extension".
        /// <see cref="GroupDomainGetAssignedUserListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDomainGetAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
