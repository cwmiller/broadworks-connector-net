using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringRedirectingRule 
{
    [XmlElement(ElementName = "criteria", IsNullable = false)]
    public string Criteria { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction Action { get; set; }
    [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true)]
    public int? CallTimeoutSeconds { get; set; }
 }
}
