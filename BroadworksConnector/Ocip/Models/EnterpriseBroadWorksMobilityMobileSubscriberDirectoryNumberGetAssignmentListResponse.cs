using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest.
    /// The response contains a table with columns: "Mobile Number", "User Id",
    /// "Last Name", "First Name","Phone Number","Extension", "Group Id", "Department" and "Mobile Network".
    /// The "Mobile Number" column contains a single DN.
    /// The "User Id", "Last Name" and "First Name" columns contains the corresponding attributes of the user possessing the DN(s).
    /// The "Phone Number" column contains a single DN.
    /// The "Group Id"   column contains the Group Id of the user.
    /// The "Department" column contains the department of the user if it is part of a department.
    /// The "Mobile Network" column contains the Mobile Network the number belongs to.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:123""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersAssignmentTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:123")]
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
