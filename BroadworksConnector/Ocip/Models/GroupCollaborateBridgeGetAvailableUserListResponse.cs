using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCollaborateBridgeGetAvailableUserListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", and "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Department Type", "Parent Department", "Parent Department Type", "Email Address".
    /// <see cref="GroupCollaborateBridgeGetAvailableUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc805893b9cc7e3e01eec64e9ad62768:230""}]")]
    public class GroupCollaborateBridgeGetAvailableUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:230")]
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
