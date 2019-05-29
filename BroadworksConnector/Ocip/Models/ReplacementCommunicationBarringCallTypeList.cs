using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringCallTypeList 
{
    [XmlElement(ElementName = "callType", IsNullable = false)]
    public List<string> CallType { get; set; }
 }
}
