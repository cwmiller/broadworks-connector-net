using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalMainMenuKeys 
{
    private string _voiceMessaging;

    [XmlElement(ElementName = "voiceMessaging", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = true, Namespace = "")]
    public string CommPilotExpressProfile {
        get => _commPilotExpressProfile;
        set {
            CommPilotExpressProfileSpecified = true;
            _commPilotExpressProfile = value;
        }
    }

    [XmlIgnore]
    public bool CommPilotExpressProfileSpecified { get; set; }
    private string _personalizedName;

    [XmlElement(ElementName = "personalizedName", IsNullable = true, Namespace = "")]
    public string PersonalizedName {
        get => _personalizedName;
        set {
            PersonalizedNameSpecified = true;
            _personalizedName = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameSpecified { get; set; }
    private string _callForwardingOptions;

    [XmlElement(ElementName = "callForwardingOptions", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "voicePortalCalling", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "hoteling", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "passcode", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "exitVoicePortal", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "externalRouting", IsNullable = true, Namespace = "")]
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
