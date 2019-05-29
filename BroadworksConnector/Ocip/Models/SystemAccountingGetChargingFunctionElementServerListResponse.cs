using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingGetChargingFunctionElementServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "chargingFunctionElementServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ChargingFunctionElementServerTable { get; set; }
 }
}
