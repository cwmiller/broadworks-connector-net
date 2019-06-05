using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _usageTable;

    [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UsageTable {
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
