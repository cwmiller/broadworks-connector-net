using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEnterpriseTrunkGetUserListRequest.
    /// The column headings for the enterpriseTrunkUserTable are: "User Id", "Last Name", "First Name", "Phone Number", "Alternate Trunk Identity", "Hiragana Last Name", "Hiragana First Name",
    /// "Extension", "Department", "Email Address" and "Route List Assigned".
        /// <see cref="GroupEnterpriseTrunkGetUserListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEnterpriseTrunkGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkUserTable;

        [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseTrunkUserTable {
            get => _enterpriseTrunkUserTable;
            set {
                EnterpriseTrunkUserTableSpecified = true;
                _enterpriseTrunkUserTable = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkUserTableSpecified { get; set; }
        
    }
}
