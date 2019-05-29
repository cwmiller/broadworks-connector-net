using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ConferenceGreetingMenuKeys 
{
    [XmlElement(ElementName = "activateConfGreeting", IsNullable = false)]
    public string ActivateConfGreeting { get; set; }
    [XmlElement(ElementName = "deactivateConfGreeting", IsNullable = false)]
    public string DeactivateConfGreeting { get; set; }
    [XmlElement(ElementName = "recordNewConfGreeting", IsNullable = false)]
    public string RecordNewConfGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentConfGreeting", IsNullable = false)]
    public string ListenToCurrentConfGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
