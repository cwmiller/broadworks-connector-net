using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _systemCarrierTable;

    [XmlElement(ElementName = "systemCarrierTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemCarrierTable {
        get => _systemCarrierTable;
        set {
            SystemCarrierTableSpecified = true;
            _systemCarrierTable = value;
        }
    }

    [XmlIgnore]
    public bool SystemCarrierTableSpecified { get; set; }
}
}
