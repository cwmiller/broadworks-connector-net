using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingAddChargingFunctionElementServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "address", IsNullable = false)]
    public string Address { get; set; }
    [XmlElement(ElementName = "isNetAddressExtended", IsNullable = false)]
    public bool IsNetAddressExtended { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ChargingFunctionElementServerType Type { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
 }
}
