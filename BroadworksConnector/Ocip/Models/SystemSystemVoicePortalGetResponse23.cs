using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemVoicePortalGetRequest23.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// networkClassOfService
    /// <see cref="SystemSystemVoicePortalGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18661""}]")]
    public class SystemSystemVoicePortalGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _callingLineIdName;

        [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CallingLineIdName
        {
            get => _callingLineIdName;
            set
            {
                CallingLineIdNameSpecified = true;
                _callingLineIdName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdNameSpecified { get; set; }

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageSpecified { get; set; }

        protected string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneSpecified { get; set; }

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        protected string _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PublicUserIdentity
        {
            get => _publicUserIdentity;
            set
            {
                PublicUserIdentitySpecified = true;
                _publicUserIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PublicUserIdentitySpecified { get; set; }

        protected string _networkVoicePortalNumber;

        [XmlElement(ElementName = "networkVoicePortalNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(23)]
        public string NetworkVoicePortalNumber
        {
            get => _networkVoicePortalNumber;
            set
            {
                NetworkVoicePortalNumberSpecified = true;
                _networkVoicePortalNumber = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkVoicePortalNumberSpecified { get; set; }

        protected bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

        [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin
        {
            get => _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;
            set
            {
                AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified = true;
                _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin = value;
            }
        }

        [XmlIgnore]
        protected bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified { get; set; }

        protected bool _useVoicePortalWizard;

        [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool UseVoicePortalWizard
        {
            get => _useVoicePortalWizard;
            set
            {
                UseVoicePortalWizardSpecified = true;
                _useVoicePortalWizard = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoicePortalWizardSpecified { get; set; }

        protected bool _isDefault;

        [XmlElement(ElementName = "isDefault", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool IsDefault
        {
            get => _isDefault;
            set
            {
                IsDefaultSpecified = true;
                _isDefault = value;
            }
        }

        [XmlIgnore]
        protected bool IsDefaultSpecified { get; set; }

        protected bool _useVoicePortalDefaultGreeting;

        [XmlElement(ElementName = "useVoicePortalDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool UseVoicePortalDefaultGreeting
        {
            get => _useVoicePortalDefaultGreeting;
            set
            {
                UseVoicePortalDefaultGreetingSpecified = true;
                _useVoicePortalDefaultGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoicePortalDefaultGreetingSpecified { get; set; }

        protected string _voicePortalGreetingFileDescription;

        [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VoicePortalGreetingFileDescription
        {
            get => _voicePortalGreetingFileDescription;
            set
            {
                VoicePortalGreetingFileDescriptionSpecified = true;
                _voicePortalGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _voicePortalGreetingMediaFileType;

        [XmlElement(ElementName = "voicePortalGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaFileType
        {
            get => _voicePortalGreetingMediaFileType;
            set
            {
                VoicePortalGreetingMediaFileTypeSpecified = true;
                _voicePortalGreetingMediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingMediaFileTypeSpecified { get; set; }

        protected bool _useVoiceMessagingDefaultGreeting;

        [XmlElement(ElementName = "useVoiceMessagingDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool UseVoiceMessagingDefaultGreeting
        {
            get => _useVoiceMessagingDefaultGreeting;
            set
            {
                UseVoiceMessagingDefaultGreetingSpecified = true;
                _useVoiceMessagingDefaultGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoiceMessagingDefaultGreetingSpecified { get; set; }

        protected string _voiceMessagingGreetingFileDescription;

        [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VoiceMessagingGreetingFileDescription
        {
            get => _voiceMessagingGreetingFileDescription;
            set
            {
                VoiceMessagingGreetingFileDescriptionSpecified = true;
                _voiceMessagingGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _voiceMessagingGreetingMediaFileType;

        [XmlElement(ElementName = "voiceMessagingGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaFileType
        {
            get => _voiceMessagingGreetingMediaFileType;
            set
            {
                VoiceMessagingGreetingMediaFileTypeSpecified = true;
                _voiceMessagingGreetingMediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingMediaFileTypeSpecified { get; set; }

        protected bool _expressMode;

        [XmlElement(ElementName = "expressMode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        public bool ExpressMode
        {
            get => _expressMode;
            set
            {
                ExpressModeSpecified = true;
                _expressMode = value;
            }
        }

        [XmlIgnore]
        protected bool ExpressModeSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18661")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
