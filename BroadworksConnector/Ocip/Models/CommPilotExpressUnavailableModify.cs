using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressUnavailableModify 
{
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify IncomingCalls { get; set; }
    [XmlElement(ElementName = "voiceMailGreeting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting VoiceMailGreeting { get; set; }
 }
}
