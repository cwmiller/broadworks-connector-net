using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest.
    /// The response contains a table with columns: "Mobile Number", "User Id",
    /// "Last Name", "First Name","Phone Number", "Extension", "Department",.
    /// The "Mobile Number" column contains a single DN.
    /// The "User Id", "Last Name" and "First Name" columns contains the corresponding attributes of the user possessing the DN(s).
    /// The "Phone Number" column contains a single DN.
    /// The "Department" column contains the department of the user if it is part of a department.
        /// <see cref="GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumberTable {
            get => _mobileSubscriberDirectoryNumberTable;
            set {
                MobileSubscriberDirectoryNumberTableSpecified = true;
                _mobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumberTableSpecified { get; set; }
        
    }
}
