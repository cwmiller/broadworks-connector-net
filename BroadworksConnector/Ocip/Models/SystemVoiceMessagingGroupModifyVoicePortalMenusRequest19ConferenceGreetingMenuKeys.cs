using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ConferenceGreetingMenuKeys 
{
    [XmlElement(ElementName = "activateConfGreeting", IsNullable = true)]
    public string ActivateConfGreeting { get; set; }
    [XmlElement(ElementName = "deactivateConfGreeting", IsNullable = true)]
    public string DeactivateConfGreeting { get; set; }
    [XmlElement(ElementName = "recordNewConfGreeting", IsNullable = true)]
    public string RecordNewConfGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentConfGreeting", IsNullable = true)]
    public string ListenToCurrentConfGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
