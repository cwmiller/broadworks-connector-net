using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCustomContactDirectoryGetAvailableUserListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", "Hiragana First Name".
    /// Replace by: GroupCustomContactDirectoryGetAvailableUserListResponse17
    /// <see cref="GroupCustomContactDirectoryGetAvailableUserListRequest"/>
    /// <see cref="GroupCustomContactDirectoryGetAvailableUserListResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9036""}]")]
    public class GroupCustomContactDirectoryGetAvailableUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9036")]
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
