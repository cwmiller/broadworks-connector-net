using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementGetEventStatusSummaryCountResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _statusCountTable;

    [XmlElement(ElementName = "statusCountTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable StatusCountTable {
        get => _statusCountTable;
        set {
            StatusCountTableSpecified = true;
            _statusCountTable = value;
        }
    }

    [XmlIgnore]
    public bool StatusCountTableSpecified { get; set; }
}
}
