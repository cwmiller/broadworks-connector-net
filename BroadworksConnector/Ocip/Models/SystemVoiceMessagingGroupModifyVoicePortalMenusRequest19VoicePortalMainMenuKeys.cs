using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalMainMenuKeys 
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
        
        private string _greetings;

        [XmlElement(ElementName = "greetings", IsNullable = true, Namespace = "")]
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
        
        private string _announcementMenu;

        [XmlElement(ElementName = "announcementMenu", IsNullable = true, Namespace = "")]
        public string AnnouncementMenu {
            get => _announcementMenu;
            set {
                AnnouncementMenuSpecified = true;
                _announcementMenu = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementMenuSpecified { get; set; }
        
        private string _personalAssistant;

        [XmlElement(ElementName = "personalAssistant", IsNullable = true, Namespace = "")]
        public string PersonalAssistant {
            get => _personalAssistant;
            set {
                PersonalAssistantSpecified = true;
                _personalAssistant = value;
            }
        }

        [XmlIgnore]
        public bool PersonalAssistantSpecified { get; set; }
        
    }
}
