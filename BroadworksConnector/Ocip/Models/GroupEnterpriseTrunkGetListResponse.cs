using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _enterpriseTrunkTable;

    [XmlElement(ElementName = "enterpriseTrunkTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable EnterpriseTrunkTable {
        get => _enterpriseTrunkTable;
        set {
            EnterpriseTrunkTableSpecified = true;
            _enterpriseTrunkTable = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseTrunkTableSpecified { get; set; }
}
}
