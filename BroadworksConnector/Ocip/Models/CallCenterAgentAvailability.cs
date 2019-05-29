using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentAvailability 
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "available", IsNullable = false)]
    public bool Available { get; set; }
 }
}
