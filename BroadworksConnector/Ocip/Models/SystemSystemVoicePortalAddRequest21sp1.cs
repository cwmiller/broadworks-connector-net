using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a system voice portal instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in IMS mode:
    /// publicUserIdentity, ignored in standalone mode if provided.
    /// 
    /// The following elements are only used in AS mode and ignored in XS data mode:
    /// networkClassOfService
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18567""}]")]
    public class SystemSystemVoicePortalAddRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _systemVoicePortalId;

        [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SystemVoicePortalId
        {
            get => _systemVoicePortalId;
            set
            {
                SystemVoicePortalIdSpecified = true;
                _systemVoicePortalId = value;
            }
        }

        [XmlIgnore]
        protected bool SystemVoicePortalIdSpecified { get; set; }

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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

        protected bool _useVoicePortalDefaultGreeting;

        [XmlElement(ElementName = "useVoicePortalDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _voicePortalGreetingFile;

        [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VoicePortalGreetingFile
        {
            get => _voicePortalGreetingFile;
            set
            {
                VoicePortalGreetingFileSpecified = true;
                _voicePortalGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingFileSpecified { get; set; }

        protected bool _useVoiceMessagingDefaultGreeting;

        [XmlElement(ElementName = "useVoiceMessagingDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _voiceMessagingGreetingFile;

        [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VoiceMessagingGreetingFile
        {
            get => _voiceMessagingGreetingFile;
            set
            {
                VoiceMessagingGreetingFileSpecified = true;
                _voiceMessagingGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingFileSpecified { get; set; }

        protected bool _expressMode;

        [XmlElement(ElementName = "expressMode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18567")]
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
