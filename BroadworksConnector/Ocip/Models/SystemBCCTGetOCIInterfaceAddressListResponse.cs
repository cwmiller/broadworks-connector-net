using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBCCTGetOCIInterfaceAddressListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false)]
    public List<string> InterfaceNetAddress { get; set; }
 }
}
