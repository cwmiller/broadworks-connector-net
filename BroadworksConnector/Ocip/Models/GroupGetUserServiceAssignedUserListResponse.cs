using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Return a table containing the list of users assigned the user service
    /// or service pack.  The table contains columns: "User Id", "Last Name",
    /// "First Name", "Department", "Phone Number", "Email Address", "Hiragana Last Name";
    /// "Hiragana First Name", "Extension".
    /// This is a response to the GroupGetUserServiceAssignedUserListRequest.
    /// <see cref="GroupGetUserServiceAssignedUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:6064""}]")]
    public class GroupGetUserServiceAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userListTable;

        [XmlElement(ElementName = "userListTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:6064")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserListTable
        {
            get => _userListTable;
            set
            {
                UserListTableSpecified = true;
                _userListTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserListTableSpecified { get; set; }

    }
}
