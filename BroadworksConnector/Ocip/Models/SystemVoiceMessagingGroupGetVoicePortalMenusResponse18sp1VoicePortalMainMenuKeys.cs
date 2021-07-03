using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37060""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalMainMenuKeys
    {

        private string _voiceMessaging;

        [XmlElement(ElementName = "voiceMessaging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoiceMessaging
        {
            get => _voiceMessaging;
            set
            {
                VoiceMessagingSpecified = true;
                _voiceMessaging = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingSpecified { get; set; }

        private string _commPilotExpressProfile;

        [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CommPilotExpressProfile
        {
            get => _commPilotExpressProfile;
            set
            {
                CommPilotExpressProfileSpecified = true;
                _commPilotExpressProfile = value;
            }
        }

        [XmlIgnore]
        protected bool CommPilotExpressProfileSpecified { get; set; }

        private string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PersonalizedName
        {
            get => _personalizedName;
            set
            {
                PersonalizedNameSpecified = true;
                _personalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameSpecified { get; set; }

        private string _callForwardingOptions;

        [XmlElement(ElementName = "callForwardingOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CallForwardingOptions
        {
            get => _callForwardingOptions;
            set
            {
                CallForwardingOptionsSpecified = true;
                _callForwardingOptions = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingOptionsSpecified { get; set; }

        private string _voicePortalCalling;

        [XmlElement(ElementName = "voicePortalCalling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoicePortalCalling
        {
            get => _voicePortalCalling;
            set
            {
                VoicePortalCallingSpecified = true;
                _voicePortalCalling = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalCallingSpecified { get; set; }

        private string _hoteling;

        [XmlElement(ElementName = "hoteling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Hoteling
        {
            get => _hoteling;
            set
            {
                HotelingSpecified = true;
                _hoteling = value;
            }
        }

        [XmlIgnore]
        protected bool HotelingSpecified { get; set; }

        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        private string _exitVoicePortal;

        [XmlElement(ElementName = "exitVoicePortal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExitVoicePortal
        {
            get => _exitVoicePortal;
            set
            {
                ExitVoicePortalSpecified = true;
                _exitVoicePortal = value;
            }
        }

        [XmlIgnore]
        protected bool ExitVoicePortalSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

        private string _externalRouting;

        [XmlElement(ElementName = "externalRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37060")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExternalRouting
        {
            get => _externalRouting;
            set
            {
                ExternalRoutingSpecified = true;
                _externalRouting = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalRoutingSpecified { get; set; }

    }
}
