using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseEnterpriseTrunkGetListRequest.
    /// Contains a table of enterprise trunks defined in the enterprise
    /// The column headings are: "Enterprise Trunk Name", "Routing Type"
    /// <see cref="EnterpriseEnterpriseTrunkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:297""}]")]
    public class EnterpriseEnterpriseTrunkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkTable;

        [XmlElement(ElementName = "enterpriseTrunkTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:297")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseTrunkTable
        {
            get => _enterpriseTrunkTable;
            set
            {
                EnterpriseTrunkTableSpecified = true;
                _enterpriseTrunkTable = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkTableSpecified { get; set; }

    }
}
