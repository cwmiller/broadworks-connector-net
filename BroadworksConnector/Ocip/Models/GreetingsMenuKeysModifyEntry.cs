using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GreetingsMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "personalizedName", IsNullable = true)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "conferenceGreeting", IsNullable = true)]
    public string ConferenceGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
