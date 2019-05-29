using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ChangeExtendedAwayGreetingMenuKeysReadEntry 
{
    [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = false)]
    public string ActivateExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "deactivateExtendedAwayGreeting", IsNullable = false)]
    public string DeactivateExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "recordNewGreeting", IsNullable = false)]
    public string RecordNewGreeting { get; set; }
    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = false)]
    public string ListenToCurrentGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
