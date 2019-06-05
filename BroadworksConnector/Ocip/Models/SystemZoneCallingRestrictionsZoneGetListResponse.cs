using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneCallingRestrictionsZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _zoneTable;

    [XmlElement(ElementName = "zoneTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ZoneTable {
        get => _zoneTable;
        set {
            ZoneTableSpecified = true;
            _zoneTable = value;
        }
    }

    [XmlIgnore]
    public bool ZoneTableSpecified { get; set; }
}
}
