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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6323""}]")]
    public class GroupGetUserServiceAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userListTable;

        [XmlElement(ElementName = "userListTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6323")]
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
