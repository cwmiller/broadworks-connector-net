using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CallForwardingOptionsMenuKeys 
{
    [XmlElement(ElementName = "activateCallForwarding", IsNullable = true)]
    public string ActivateCallForwarding { get; set; }
    [XmlElement(ElementName = "deactivateCallForwarding", IsNullable = true)]
    public string DeactivateCallForwarding { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestination", IsNullable = true)]
    public string ChangeCallForwardingDestination { get; set; }
    [XmlElement(ElementName = "listenToCallForwardingStatus", IsNullable = true)]
    public string ListenToCallForwardingStatus { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
