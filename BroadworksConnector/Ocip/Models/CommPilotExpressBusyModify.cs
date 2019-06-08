using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressBusyModify 
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
    private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify _voiceMailNotify;

    [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify VoiceMailNotify {
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
