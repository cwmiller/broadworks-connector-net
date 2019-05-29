using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBCCTDeleteOCIInterfaceAddressRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false)]
    public string InterfaceNetAddress { get; set; }
 }
}
