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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39006""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20VoicePortalMainMenuKeys
    {

        protected string _voiceMessaging;

        [XmlElement(ElementName = "voiceMessaging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoiceMessaging
        {
            get => _voiceMessaging;
            set
            {
                VoiceMessagingSpecified = (value != null);
                _voiceMessaging = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingSpecified { get; set; }

        protected string _commPilotExpressProfile;

        [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CommPilotExpressProfile
        {
            get => _commPilotExpressProfile;
            set
            {
                CommPilotExpressProfileSpecified = (value != null);
                _commPilotExpressProfile = value;
            }
        }

        [XmlIgnore]
        protected bool CommPilotExpressProfileSpecified { get; set; }

        protected string _greetings;

        [XmlElement(ElementName = "greetings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Greetings
        {
            get => _greetings;
            set
            {
                GreetingsSpecified = (value != null);
                _greetings = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingsSpecified { get; set; }

        protected string _callForwardingOptions;

        [XmlElement(ElementName = "callForwardingOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CallForwardingOptions
        {
            get => _callForwardingOptions;
            set
            {
                CallForwardingOptionsSpecified = (value != null);
                _callForwardingOptions = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingOptionsSpecified { get; set; }

        protected string _voicePortalCalling;

        [XmlElement(ElementName = "voicePortalCalling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoicePortalCalling
        {
            get => _voicePortalCalling;
            set
            {
                VoicePortalCallingSpecified = (value != null);
                _voicePortalCalling = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalCallingSpecified { get; set; }

        protected string _hoteling;

        [XmlElement(ElementName = "hoteling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Hoteling
        {
            get => _hoteling;
            set
            {
                HotelingSpecified = (value != null);
                _hoteling = value;
            }
        }

        [XmlIgnore]
        protected bool HotelingSpecified { get; set; }

        protected string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = (value != null);
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        protected string _exitVoicePortal;

        [XmlElement(ElementName = "exitVoicePortal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExitVoicePortal
        {
            get => _exitVoicePortal;
            set
            {
                ExitVoicePortalSpecified = (value != null);
                _exitVoicePortal = value;
            }
        }

        [XmlIgnore]
        protected bool ExitVoicePortalSpecified { get; set; }

        protected string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = (value != null);
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

        protected string _externalRouting;

        [XmlElement(ElementName = "externalRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExternalRouting
        {
            get => _externalRouting;
            set
            {
                ExternalRoutingSpecified = (value != null);
                _externalRouting = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalRoutingSpecified { get; set; }

        protected string _announcement;

        [XmlElement(ElementName = "announcement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39006")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Announcement
        {
            get => _announcement;
            set
            {
                AnnouncementSpecified = (value != null);
                _announcement = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementSpecified { get; set; }

    }
}
