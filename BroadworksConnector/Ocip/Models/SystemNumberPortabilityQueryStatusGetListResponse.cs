using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _statusTable;

    [XmlElement(ElementName = "statusTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable StatusTable {
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
