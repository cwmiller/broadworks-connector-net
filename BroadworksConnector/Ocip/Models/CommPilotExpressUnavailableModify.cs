using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressUnavailableModify 
{
    private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify _incomingCalls;

    [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify IncomingCalls {
        get => _incomingCalls;
        set {
            IncomingCallsSpecified = true;
            _incomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting _voiceMailGreeting;

    [XmlElement(ElementName = "voiceMailGreeting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting VoiceMailGreeting {
        get => _voiceMailGreeting;
        set {
            VoiceMailGreetingSpecified = true;
            _voiceMailGreeting = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMailGreetingSpecified { get; set; }
}
}