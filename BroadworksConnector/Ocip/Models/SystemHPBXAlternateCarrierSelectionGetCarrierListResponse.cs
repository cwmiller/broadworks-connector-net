using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXAlternateCarrierSelectionGetCarrierListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _hPBXAlternateCarriersTable;

    [XmlElement(ElementName = "HPBXAlternateCarriersTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable HPBXAlternateCarriersTable {
        get => _hPBXAlternateCarriersTable;
        set {
            HPBXAlternateCarriersTableSpecified = true;
            _hPBXAlternateCarriersTable = value;
        }
    }

    [XmlIgnore]
    public bool HPBXAlternateCarriersTableSpecified { get; set; }
}
}
