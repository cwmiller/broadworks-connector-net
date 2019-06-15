using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAccountAuthorizationCodesGetAvailableUserListRequest.
    /// The column headings are: "User Id", "Last Name", "First Name", "Hiragana Last Name" and
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address".
        /// <see cref="GroupAccountAuthorizationCodesGetAvailableUserListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccountAuthorizationCodesGetAvailableUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
