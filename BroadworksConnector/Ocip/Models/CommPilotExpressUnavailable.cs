using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressUnavailable 
{
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls { get; set; }
    [XmlElement(ElementName = "voiceMailGreeting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting VoiceMailGreeting { get; set; }
 }
}
