using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestDisableMessageDepositMenuKeys 
{
    [XmlElement(ElementName = "disconnectAfterGreeting", IsNullable = true)]
    public string DisconnectAfterGreeting { get; set; }
    [XmlElement(ElementName = "forwardAfterGreeting", IsNullable = true)]
    public string ForwardAfterGreeting { get; set; }
    [XmlElement(ElementName = "changeForwardingDestination", IsNullable = true)]
    public string ChangeForwardingDestination { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
