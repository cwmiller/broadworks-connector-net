using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeBusyOrNoAnswerGreetingMenuKeys 
{
    [XmlElement(ElementName = "recordNewGreeting", IsNullable = true)]
    public string RecordNewGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = true)]
    public string ListenToCurrentGreeting { get; set; }
    [XmlElement(ElementName = "revertToSystemDefaultGreeting", IsNullable = true)]
    public string RevertToSystemDefaultGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
