using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:398""}]")]
    public class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:398")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumberTable
        {
            get => _mobileSubscriberDirectoryNumberTable;
            set
            {
                MobileSubscriberDirectoryNumberTableSpecified = true;
                _mobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileSubscriberDirectoryNumberTableSpecified { get; set; }

    }
}
