using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest.
    /// The response contains a table with columns: "Mobile Number", "User Id", "Last Name", "First Name", "Phone Number", "Extension",
    /// "Group Id", "Department", "Department Type", "Parent Department", "Parent Department Type", "Mobile Network", "Country Code",
    /// "National Prefix", "Available", "Mobile Country Code", "Mobile National Prefix".
    /// The "Mobile Number" column contains a single DN.
    /// The "User Id", "Last Name" and "First Name" columns contains the corresponding attributes of the user possessing the DN(s).
    /// The "Phone Number" column contains a single DN.
    /// The "Group Id" column contains the Group Id of the user.
    /// The "Group Name" column contains the Group Name of the user.
    /// The "Department" column contains the department of the user if it is part of a department.
    /// The "Parent Department" column contains the parent department of the user if it is part of a department.
    /// The "Department Type" and "Parent Department Type" columns will contain the values "Enterprise" or "Group".
    /// The "Mobile Network" column contains the Mobile Network the number belongs to.
    /// The "Country Code" column indicates the dialing prefix for the phone number.
    /// The "National Prefix" column indicates the digit sequence to be dialed before the telephone number.
    /// The "Available" column indicates if the Mobile Number is available.
    /// The "Mobile Country Code" column indicates the dialing prefix for the mobile number.
    /// The "Mobile National Prefix" column indicates the digit sequence to be dialed before the mobile number.
        /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersAssignmentTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable {
            get => _mobileSubscriberDirectoryNumbersAssignmentTable;
            set {
                MobileSubscriberDirectoryNumbersAssignmentTableSpecified = true;
                _mobileSubscriberDirectoryNumbersAssignmentTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumbersAssignmentTableSpecified { get; set; }
        
    }
}
