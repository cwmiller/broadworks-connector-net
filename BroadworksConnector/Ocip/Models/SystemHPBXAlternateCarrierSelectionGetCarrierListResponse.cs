using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXAlternateCarrierSelectionGetCarrierListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _hPBXAlternateCarriersTable;

    [XmlElement(ElementName = "HPBXAlternateCarriersTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable HPBXAlternateCarriersTable {
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
