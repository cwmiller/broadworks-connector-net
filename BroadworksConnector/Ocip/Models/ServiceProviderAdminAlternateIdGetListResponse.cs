using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdminAlternateIdGetListRequest.
    /// Contains a table of the main admin user id and the alternate admin user ids, the column headings are: "User Id", "Description", "Alternate".
    /// The possible values for "Alternate" are "true" and "false".
    /// The "Description" is only present for alternate admin user Ids.
    /// <see cref="ServiceProviderAdminAlternateIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1322""}]")]
    public class ServiceProviderAdminAlternateIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _adminUserIdTable;

        [XmlElement(ElementName = "adminUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1322")]
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
