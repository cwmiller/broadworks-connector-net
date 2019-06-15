using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetListInGroupPagedSortedListRequest.
    /// Contains a table with column headings : "User Id",
    /// "Last Name", "First Name", "Department", "Department Type",
    /// "Parent Department","Parent Department Type", "Phone Number",
    /// "Phone Number Activated", "Email Address",  "Hiragana Last Name",
    /// "Hiragana First Name", "In Trunk Group", "Extension", "Country Code",
    /// "National Prefix" in a row for each user.
    /// 
    /// The "Department Type" and "Parent Department Type" columns
    /// will contain the values "Enterprise" or "Group".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Country Code", "National Prefix
        /// <see cref="UserGetListInGroupPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetListInGroupPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
