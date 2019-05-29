using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressBusyModify 
{
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify IncomingCalls { get; set; }
    [XmlElement(ElementName = "voiceMailNotify", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify VoiceMailNotify { get; set; }
 }
}
