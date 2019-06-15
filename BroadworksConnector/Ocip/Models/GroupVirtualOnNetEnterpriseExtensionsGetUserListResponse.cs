using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest.
    /// Contains a table with column headings: "Last Name",
    /// "First Name", "Phone Number", "Extension",
    /// "Virtual On-Net Call Type Name"
    /// in a row for each user.
        /// <see cref="GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
