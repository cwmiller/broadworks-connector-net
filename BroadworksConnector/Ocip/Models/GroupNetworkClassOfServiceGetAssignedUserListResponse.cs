using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupNetworkClassOfServiceGetAssignedUserListRequest.
    /// Contains a table of users that have the Network Class of Service
    /// assigned. The column headings are: "User Id", "User Type", "Last Name", "First Name",
    /// "Department", "Phone Number", "Email Address", "Service Provider Id",
    /// "Group Id", "Hiragana Last Name" and "Hiragana First Name" , "Extension".
    /// <see cref="GroupNetworkClassOfServiceGetAssignedUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:3939""}]")]
    public class GroupNetworkClassOfServiceGetAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3939")]
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
