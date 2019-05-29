using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1DisableMessageDepositMenuKeys 
{
    [XmlElement(ElementName = "disconnectAfterGreeting", IsNullable = false)]
    public string DisconnectAfterGreeting { get; set; }
    [XmlElement(ElementName = "forwardAfterGreeting", IsNullable = false)]
    public string ForwardAfterGreeting { get; set; }
    [XmlElement(ElementName = "changeForwardingDestination", IsNullable = false)]
    public string ChangeForwardingDestination { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
