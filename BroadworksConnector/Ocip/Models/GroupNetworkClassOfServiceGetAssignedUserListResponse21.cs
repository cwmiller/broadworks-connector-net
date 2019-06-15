using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupNetworkClassOfServiceGetAssignedUserListRequest21.
    /// Contains a table of users that have the Network Class of Service
    /// assigned. The column headings are: "User Id", "User Type", "Last Name", "First Name",
    /// "Department", "Phone Number", "Email Address", "Service Provider Id",
    /// "Group Id", "Hiragana Last Name" and "Hiragana First Name" , "Extension".
    /// The User type column will display Auto Attendant and the Call Center subtype.
    /// Call Center - Basic, Call Center - Standard and Call Center - Premium will be displayed instead of Call Center and
    /// Auto Attendant (for the Basic Auto Attendant) and Auto Attendant - Standard instead of Auto Attendant.
        /// <see cref="GroupNetworkClassOfServiceGetAssignedUserListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupNetworkClassOfServiceGetAssignedUserListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
