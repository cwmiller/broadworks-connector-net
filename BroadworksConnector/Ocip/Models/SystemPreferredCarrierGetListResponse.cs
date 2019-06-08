using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _systemCarrierTable;

    [XmlElement(ElementName = "systemCarrierTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SystemCarrierTable {
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
