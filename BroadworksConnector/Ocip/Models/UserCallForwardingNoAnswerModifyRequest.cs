using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingNoAnswerModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true)]
    public string ForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings NumberOfRings { get; set; }
 }
}
