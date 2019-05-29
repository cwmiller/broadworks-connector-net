using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExecutiveAssistantOptInStatus 
{
    [XmlElement(ElementName = "executiveUserId", IsNullable = false)]
    public string ExecutiveUserId { get; set; }
    [XmlElement(ElementName = "optIn", IsNullable = false)]
    public bool OptIn { get; set; }
 }
}
