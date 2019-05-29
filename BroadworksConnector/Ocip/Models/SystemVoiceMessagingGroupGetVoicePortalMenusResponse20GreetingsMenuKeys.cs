using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20GreetingsMenuKeys 
{
    [XmlElement(ElementName = "personalizedName", IsNullable = false)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "conferenceGreeting", IsNullable = false)]
    public string ConferenceGreeting { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
