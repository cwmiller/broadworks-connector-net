using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressBusy 
{
    private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException _incomingCalls;

    [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls {
        get => _incomingCalls;
        set {
            IncomingCallsSpecified = true;
            _incomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify _voiceMailNotify;

    [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify VoiceMailNotify {
        get => _voiceMailNotify;
        set {
            VoiceMailNotifySpecified = true;
            _voiceMailNotify = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMailNotifySpecified { get; set; }
}
}
