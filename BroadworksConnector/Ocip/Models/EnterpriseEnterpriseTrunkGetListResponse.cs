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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:305""}]")]
    public class EnterpriseEnterpriseTrunkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkTable;

        [XmlElement(ElementName = "enterpriseTrunkTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:305")]
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
        protected bool EnterpriseTrunkTableSpecified { get; set; }

    }
}
