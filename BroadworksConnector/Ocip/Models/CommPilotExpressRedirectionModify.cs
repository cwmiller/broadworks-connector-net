using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressRedirectionModify 
{
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionAction Action { get; set; }
    [XmlElement(ElementName = "forwardingPhoneNumber", IsNullable = true)]
    public string ForwardingPhoneNumber { get; set; }
 }
}
