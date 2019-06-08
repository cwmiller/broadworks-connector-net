using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkTable;

    [XmlElement(ElementName = "enterpriseTrunkTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseTrunkTable {
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
