using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAlternateUserIdGetListRequest.
    /// Contains a table of the main user id and the alternate user ids, the column headings are: "User Id", "Description", "Alternate".
    /// The possible values for "Alternate" are "true" and "false".
    /// The "Description" is only present for alternate user Ids.
    /// <see cref="UserAlternateUserIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:442""}]")]
    public class UserAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userIdTable;

        [XmlElement(ElementName = "userIdTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:442")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserIdTable
        {
            get => _userIdTable;
            set
            {
                UserIdTableSpecified = true;
                _userIdTable = value;
            }
        }

        [XmlIgnore]
        public bool UserIdTableSpecified { get; set; }

    }
}
