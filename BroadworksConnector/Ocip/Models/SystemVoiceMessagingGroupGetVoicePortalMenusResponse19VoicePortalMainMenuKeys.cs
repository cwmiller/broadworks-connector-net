using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalMainMenuKeys 
{
    private string _voiceMessaging;

    [XmlElement(ElementName = "voiceMessaging", IsNullable = false, Namespace = "")]
    public string VoiceMessaging {
        get => _voiceMessaging;
        set {
            VoiceMessagingSpecified = true;
            _voiceMessaging = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingSpecified { get; set; }
    private string _commPilotExpressProfile;

    [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = false, Namespace = "")]
    public string CommPilotExpressProfile {
        get => _commPilotExpressProfile;
        set {
            CommPilotExpressProfileSpecified = true;
            _commPilotExpressProfile = value;
        }
    }

    [XmlIgnore]
    public bool CommPilotExpressProfileSpecified { get; set; }
    private string _greetings;

    [XmlElement(ElementName = "greetings", IsNullable = false, Namespace = "")]
    public string Greetings {
        get => _greetings;
        set {
            GreetingsSpecified = true;
            _greetings = value;
        }
    }

    [XmlIgnore]
    public bool GreetingsSpecified { get; set; }
    private string _callForwardingOptions;

    [XmlElement(ElementName = "callForwardingOptions", IsNullable = false, Namespace = "")]
    public string CallForwardingOptions {
        get => _callForwardingOptions;
        set {
            CallForwardingOptionsSpecified = true;
            _callForwardingOptions = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingOptionsSpecified { get; set; }
    private string _voicePortalCalling;

    [XmlElement(ElementName = "voicePortalCalling", IsNullable = false, Namespace = "")]
    public string VoicePortalCalling {
        get => _voicePortalCalling;
        set {
            VoicePortalCallingSpecified = true;
            _voicePortalCalling = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalCallingSpecified { get; set; }
    private string _hoteling;

    [XmlElement(ElementName = "hoteling", IsNullable = false, Namespace = "")]
    public string Hoteling {
        get => _hoteling;
        set {
            HotelingSpecified = true;
            _hoteling = value;
        }
    }

    [XmlIgnore]
    public bool HotelingSpecified { get; set; }
    private string _passcode;

    [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
    public string Passcode {
        get => _passcode;
        set {
            PasscodeSpecified = true;
            _passcode = value;
        }
    }

    [XmlIgnore]
    public bool PasscodeSpecified { get; set; }
    private string _exitVoicePortal;

    [XmlElement(ElementName = "exitVoicePortal", IsNullable = false, Namespace = "")]
    public string ExitVoicePortal {
        get => _exitVoicePortal;
        set {
            ExitVoicePortalSpecified = true;
            _exitVoicePortal = value;
        }
    }

    [XmlIgnore]
    public bool ExitVoicePortalSpecified { get; set; }
    private string _repeatMenu;

    [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
    public string RepeatMenu {
        get => _repeatMenu;
        set {
            RepeatMenuSpecified = true;
            _repeatMenu = value;
        }
    }

    [XmlIgnore]
    public bool RepeatMenuSpecified { get; set; }
    private string _externalRouting;

    [XmlElement(ElementName = "externalRouting", IsNullable = false, Namespace = "")]
    public string ExternalRouting {
        get => _externalRouting;
        set {
            ExternalRoutingSpecified = true;
            _externalRouting = value;
        }
    }

    [XmlIgnore]
    public bool ExternalRoutingSpecified { get; set; }
}
}
