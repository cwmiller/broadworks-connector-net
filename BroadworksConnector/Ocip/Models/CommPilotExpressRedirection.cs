using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressRedirection 
{
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionAction Action { get; set; }
    [XmlElement(ElementName = "forwardingPhoneNumber", IsNullable = false)]
    public string ForwardingPhoneNumber { get; set; }
 }
}
