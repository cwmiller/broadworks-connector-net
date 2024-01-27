using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAdminAlternateIdGetListRequest.
    /// Contains a table of the main admin user id and the alternate admin user ids, the column headings are: "User Id", "Description", "Alternate".
    /// The possible values for "Alternate" are "true" and "false".
    /// The "Description" is only present for alternate admin user Ids.
    /// <see cref="GroupAdminAlternateIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1487""}]")]
    public class GroupAdminAlternateIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _adminUserIdTable;

        [XmlElement(ElementName = "adminUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1487")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AdminUserIdTable
        {
            get => _adminUserIdTable;
            set
            {
                AdminUserIdTableSpecified = true;
                _adminUserIdTable = value;
            }
        }

        [XmlIgnore]
        protected bool AdminUserIdTableSpecified { get; set; }

    }
}
