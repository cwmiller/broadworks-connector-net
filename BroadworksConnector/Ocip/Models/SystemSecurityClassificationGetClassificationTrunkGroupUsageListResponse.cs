using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

    [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable {
        get => _usageTable;
        set {
            UsageTableSpecified = true;
            _usageTable = value;
        }
    }

    [XmlIgnore]
    public bool UsageTableSpecified { get; set; }
}
}
