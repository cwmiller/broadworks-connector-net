using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCallForwardingNoAnswerInfo 
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false)]
    public string ForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings NumberOfRings { get; set; }
 }
}
