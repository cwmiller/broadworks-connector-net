using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressBusy 
{
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls { get; set; }
    [XmlElement(ElementName = "voiceMailNotify", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify VoiceMailNotify { get; set; }
 }
}
