using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingGetChargingFunctionElementServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _chargingFunctionElementServerTable;

    [XmlElement(ElementName = "chargingFunctionElementServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ChargingFunctionElementServerTable {
        get => _chargingFunctionElementServerTable;
        set {
            ChargingFunctionElementServerTableSpecified = true;
            _chargingFunctionElementServerTable = value;
        }
    }

    [XmlIgnore]
    public bool ChargingFunctionElementServerTableSpecified { get; set; }
}
}
