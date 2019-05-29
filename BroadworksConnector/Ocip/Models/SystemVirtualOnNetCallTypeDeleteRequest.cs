using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVirtualOnNetCallTypeDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false)]
    public string VirtualOnNetCallTypeName { get; set; }
 }
}
