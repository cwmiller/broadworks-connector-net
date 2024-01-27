using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerAdminAlternateIdGetListRequest.
    /// Contains a table of the main admin user id and the alternate admin user ids, the column headings are: "User Id", "Description", "Alternate".
    /// The possible values for "Alternate" are "true" and "false".
    /// The "Description" is only present for alternate admin user Ids.
    /// <see cref="ResellerAdminAlternateIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:170""}]")]
    public class ResellerAdminAlternateIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _adminUserIdTable;

        [XmlElement(ElementName = "adminUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:170")]
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
