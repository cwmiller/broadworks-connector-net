using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemVoicePortalGetRequest.
    /// 
    /// Replaced by: SystemSystemVoicePortalGetResponse21sp1.
    /// <see cref="SystemSystemVoicePortalGetRequest"/>
    /// <see cref="SystemSystemVoicePortalGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42317""}]")]
    public class SystemSystemVoicePortalGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool NameSpecified { get; set; }

        private string _callingLineIdName;

        [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool CallingLineIdNameSpecified { get; set; }

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool LanguageSpecified { get; set; }

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool TimeZoneSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool PhoneNumberSpecified { get; set; }

        private string _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool PublicUserIdentitySpecified { get; set; }

        private string _networkVoicePortalNumber;

        [XmlElement(ElementName = "networkVoicePortalNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool NetworkVoicePortalNumberSpecified { get; set; }

        private bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

        [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified { get; set; }

        private bool _useVoicePortalWizard;

        [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool UseVoicePortalWizardSpecified { get; set; }

        private bool _isDefault;

        [XmlElement(ElementName = "isDefault", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool IsDefaultSpecified { get; set; }

        private bool _useVoicePortalDefaultGreeting;

        [XmlElement(ElementName = "useVoicePortalDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool UseVoicePortalDefaultGreetingSpecified { get; set; }

        private string _voicePortalGreetingFileDescription;

        [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool VoicePortalGreetingFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _voicePortalGreetingMediaFileType;

        [XmlElement(ElementName = "voicePortalGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool VoicePortalGreetingMediaFileTypeSpecified { get; set; }

        private bool _useVoiceMessagingDefaultGreeting;

        [XmlElement(ElementName = "useVoiceMessagingDefaultGreeting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool UseVoiceMessagingDefaultGreetingSpecified { get; set; }

        private string _voiceMessagingGreetingFileDescription;

        [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool VoiceMessagingGreetingFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _voiceMessagingGreetingMediaFileType;

        [XmlElement(ElementName = "voiceMessagingGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42317")]
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
        public bool VoiceMessagingGreetingMediaFileTypeSpecified { get; set; }

    }
}
