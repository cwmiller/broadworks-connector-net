using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCustomContactDirectoryGetRequest.
    /// The response contains all the group's custom contact directory names.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name".
    /// Replace by: GroupCustomContactDirectoryGetResponse17
        /// <see cref="GroupCustomContactDirectoryGetRequest"/>
        /// <see cref="GroupCustomContactDirectoryGetResponse17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCustomContactDirectoryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
