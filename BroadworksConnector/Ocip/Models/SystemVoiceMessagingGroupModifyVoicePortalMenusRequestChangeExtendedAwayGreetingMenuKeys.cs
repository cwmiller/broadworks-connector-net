using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeExtendedAwayGreetingMenuKeys 
{
    [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = true)]
    public string ActivateExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "deactivateExtendedAwayGreeting", IsNullable = true)]
    public string DeactivateExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "recordNewGreeting", IsNullable = true)]
    public string RecordNewGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = true)]
    public string ListenToCurrentGreeting { get; set; }
    [XmlElement(ElementName = "enableMessageDeposit", IsNullable = true)]
    public string EnableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = true)]
    public string DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
