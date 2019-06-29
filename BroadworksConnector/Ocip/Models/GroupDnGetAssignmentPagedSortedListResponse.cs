using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetAssignmentPagedSortedListRequest.
    /// 
    /// The response contains a table with columns: "Phone Numbers", "Department", "Department Type",
    /// "Parent Department", "Parent Department Type", "Activated", "Available", "User Id",
    /// "Last Name", "First Name", "Extension", "Email Address", "User Type", "Country Code", "National Prefix".
    /// The "Phone Numbers" column contains either a single DN or a range of DNs.
    /// The "User Id", "Last Name" and "First Name" columns contains the corresponding attributes of the user possessing the DN(s).
    /// For a service instance, "Last Name" contains the service instance name and "First Name" column contains the corresponding enumerated UserType value.
    /// The "Department" column contains the department of the DN, not the department of the user or service instance.
    /// The "Department Type" and "Parent Department Type" columns will contain the values "Enterprise" or "Group".
    /// The "Activated" column indicates if the DN or DN range has been activated.  Only has a value if the DN(s) is assigned to a user.
    /// The "User Type" column contains the corresponding enumerated UserType value.
    /// The "Country Code" column indicates the dialing prefix for the phone number.
    /// The "National Prefix" column indicates the digit sequence to be dialed before the telephone number.
    /// NOTE: the same phone number can show up in the list twice if the phone number is being used as the group calling line Id.
    /// <see cref="GroupDnGetAssignmentPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4284""}]")]
    public class GroupDnGetAssignmentPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4284")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnTableSpecified { get; set; }

    }
}
