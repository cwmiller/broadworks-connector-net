using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeBusyOrNoAnswerGreetingMenuKeys 
{
    [XmlElement(ElementName = "recordNewGreeting", IsNullable = false)]
    public string RecordNewGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = false)]
    public string ListenToCurrentGreeting { get; set; }
    [XmlElement(ElementName = "revertToSystemDefaultGreeting", IsNullable = false)]
    public string RevertToSystemDefaultGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
