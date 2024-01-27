using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetListInSystemRequest.
    /// Contains a table with column headings : "User Id", "Group Id", "Service Provider Id", "Last Name", "First Name",
    /// "Department", "Phone Number", "Phone Number Activated", "Email Address",  "Hiragana Last Name", "Hiragana First Name", "In Trunk Group", "Extension", "Reseller Id", "User External Id"
    /// in a row for each user.
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// "User External Id"
    /// <see cref="UserGetListInSystemRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2055""}]")]
    public class UserGetListInSystemResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2055")]
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
