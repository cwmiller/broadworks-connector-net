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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:459""}]")]
    public class UserAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userIdTable;

        [XmlElement(ElementName = "userIdTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:459")]
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
        protected bool UserIdTableSpecified { get; set; }

    }
}
