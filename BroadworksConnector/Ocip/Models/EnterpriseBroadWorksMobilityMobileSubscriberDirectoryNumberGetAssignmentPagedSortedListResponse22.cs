using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListRequest22.
    /// The response contains the number of entries that would be returned if the response was not page size restricted.
    /// Contains a table with columns: "Mobile Number", "User Id", "Last Name", "First Name", "Phone Number", "Extension",
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
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:203""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:203")]
        public int TotalNumberOfRows
        {
            get => _totalNumberOfRows;
            set
            {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        protected bool TotalNumberOfRowsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersAssignmentTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:203")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable
        {
            get => _mobileSubscriberDirectoryNumbersAssignmentTable;
            set
            {
                MobileSubscriberDirectoryNumbersAssignmentTableSpecified = true;
                _mobileSubscriberDirectoryNumbersAssignmentTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileSubscriberDirectoryNumbersAssignmentTableSpecified { get; set; }

    }
}
