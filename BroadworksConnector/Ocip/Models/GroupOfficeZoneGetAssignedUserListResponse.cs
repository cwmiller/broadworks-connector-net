using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOfiiceZoneGetAssignedUserListRequest.
    /// Contains a table of users that have the Office Zone assigned. The column headings are: "User Id", "User Type", "Last Name",
    /// "First Name", "Department", "Phone Number", "Email Address", "Hiragana Last Name" and "Hiragana First Name", "Extension".
    /// Office Zones can only be unassigned if the Location-Based Calling Restrictions has been authorized to the group otherwise the request will fail.
    /// <see cref="GroupOfiiceZoneGetAssignedUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6757""}]")]
    public class GroupOfficeZoneGetAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6757")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}
