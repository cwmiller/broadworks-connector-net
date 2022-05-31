using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetListInGroupPagedSortedListRequest.
    /// Contains a table with column headings : "User Id",
    /// "Last Name", "First Name", "Department", "Department Type",
    /// "Parent Department","Parent Department Type", "Phone Number",
    /// "Phone Number Activated", "Email Address",  "Hiragana Last Name",
    /// "Hiragana First Name", "In Trunk Group", "Extension", "Country Code",
    /// "National Prefix", "User External Id" in a row for each user.
    /// 
    /// The "Department Type" and "Parent Department Type" columns
    /// will contain the values "Enterprise" or "Group".
    /// 
    /// The following columns are only populated in AS data mode:
    /// "Country Code", "National Prefix", "User External Id"
    /// <see cref="UserGetListInGroupPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1896""}]")]
    public class UserGetListInGroupPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1896")]
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
