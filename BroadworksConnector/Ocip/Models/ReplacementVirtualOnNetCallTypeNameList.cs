using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementVirtualOnNetCallTypeNameList 
{
    [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false)]
    public List<string> VirtualOnNetCallTypeName { get; set; }
 }
}
