using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CallForwardingOptionsMenuKeys 
{
    [XmlElement(ElementName = "activateCallForwarding", IsNullable = false)]
    public string ActivateCallForwarding { get; set; }
    [XmlElement(ElementName = "deactivateCallForwarding", IsNullable = false)]
    public string DeactivateCallForwarding { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestination", IsNullable = false)]
    public string ChangeCallForwardingDestination { get; set; }
    [XmlElement(ElementName = "listenToCallForwardingStatus", IsNullable = false)]
    public string ListenToCallForwardingStatus { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
