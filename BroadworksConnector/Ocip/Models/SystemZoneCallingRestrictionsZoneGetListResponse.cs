using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneCallingRestrictionsZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _zoneTable;

    [XmlElement(ElementName = "zoneTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ZoneTable {
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
