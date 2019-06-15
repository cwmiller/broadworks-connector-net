using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Return a table containing the list of users assigned the user service
    /// or service pack.  The table contains columns: "User Id", "Last Name",
    /// "First Name", "Department", "Phone Number", "Email Address", "Hiragana Last Name";
    /// "Hiragana First Name", "Extension".
    /// This is a response to the GroupGetUserServiceAssignedUserListRequest.
        /// <see cref="GroupGetUserServiceAssignedUserListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGetUserServiceAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userListTable;

        [XmlElement(ElementName = "userListTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserListTable {
            get => _userListTable;
            set {
                UserListTableSpecified = true;
                _userListTable = value;
            }
        }

        [XmlIgnore]
        public bool UserListTableSpecified { get; set; }
        
    }
}
