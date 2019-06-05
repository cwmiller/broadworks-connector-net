using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _statusTable;

    [XmlElement(ElementName = "statusTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable StatusTable {
        get => _statusTable;
        set {
            StatusTableSpecified = true;
            _statusTable = value;
        }
    }

    [XmlIgnore]
    public bool StatusTableSpecified { get; set; }
}
}
