using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserHotelingGuestGetAvailableUserListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Association Limit Hours", "Enable Association Limit",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="UserHotelingGuestGetAvailableUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b3a47d1de480374e33d6efb9aa2bd2d0:67""}]")]
    public class UserHotelingGuestGetAvailableUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _hostUserTable;

        [XmlElement(ElementName = "hostUserTable", IsNullable = false, Namespace = "")]
        [Group(@"b3a47d1de480374e33d6efb9aa2bd2d0:67")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HostUserTable
        {
            get => _hostUserTable;
            set
            {
                HostUserTableSpecified = true;
                _hostUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool HostUserTableSpecified { get; set; }

    }
}
