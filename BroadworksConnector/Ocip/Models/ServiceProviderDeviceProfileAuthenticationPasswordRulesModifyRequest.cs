using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the service provider level device profile authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3197""}]")]
    public class ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected bool? _useServiceProviderSettings;

        [XmlElement(ElementName = "useServiceProviderSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? UseServiceProviderSettings
        {
            get => _useServiceProviderSettings;
            set
            {
                UseServiceProviderSettingsSpecified = (value != null);
                _useServiceProviderSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseServiceProviderSettingsSpecified { get; set; }

        protected bool? _disallowAuthenticationName;

        [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? DisallowAuthenticationName
        {
            get => _disallowAuthenticationName;
            set
            {
                DisallowAuthenticationNameSpecified = (value != null);
                _disallowAuthenticationName = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowAuthenticationNameSpecified { get; set; }

        protected bool? _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? DisallowOldPassword
        {
            get => _disallowOldPassword;
            set
            {
                DisallowOldPasswordSpecified = (value != null);
                _disallowOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowOldPasswordSpecified { get; set; }

        protected bool? _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? DisallowReversedOldPassword
        {
            get => _disallowReversedOldPassword;
            set
            {
                DisallowReversedOldPasswordSpecified = (value != null);
                _disallowReversedOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedOldPasswordSpecified { get; set; }

        protected bool? _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? RestrictMinDigits
        {
            get => _restrictMinDigits;
            set
            {
                RestrictMinDigitsSpecified = (value != null);
                _restrictMinDigits = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinDigitsSpecified { get; set; }

        protected int? _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinDigits
        {
            get => _minDigits;
            set
            {
                MinDigitsSpecified = (value != null);
                _minDigits = value;
            }
        }

        [XmlIgnore]
        protected bool MinDigitsSpecified { get; set; }

        protected bool? _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? RestrictMinUpperCaseLetters
        {
            get => _restrictMinUpperCaseLetters;
            set
            {
                RestrictMinUpperCaseLettersSpecified = (value != null);
                _restrictMinUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinUpperCaseLettersSpecified { get; set; }

        protected int? _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinUpperCaseLetters
        {
            get => _minUpperCaseLetters;
            set
            {
                MinUpperCaseLettersSpecified = (value != null);
                _minUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinUpperCaseLettersSpecified { get; set; }

        protected bool? _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? RestrictMinLowerCaseLetters
        {
            get => _restrictMinLowerCaseLetters;
            set
            {
                RestrictMinLowerCaseLettersSpecified = (value != null);
                _restrictMinLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinLowerCaseLettersSpecified { get; set; }

        protected int? _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinLowerCaseLetters
        {
            get => _minLowerCaseLetters;
            set
            {
                MinLowerCaseLettersSpecified = (value != null);
                _minLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinLowerCaseLettersSpecified { get; set; }

        protected bool? _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? RestrictMinNonAlphanumericCharacters
        {
            get => _restrictMinNonAlphanumericCharacters;
            set
            {
                RestrictMinNonAlphanumericCharactersSpecified = (value != null);
                _restrictMinNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        protected int? _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinNonAlphanumericCharacters
        {
            get => _minNonAlphanumericCharacters;
            set
            {
                MinNonAlphanumericCharactersSpecified = (value != null);
                _minNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool MinNonAlphanumericCharactersSpecified { get; set; }

        protected int? _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(3)]
        [MaxInclusive(40)]
        public int? MinLength
        {
            get => _minLength;
            set
            {
                MinLengthSpecified = (value != null);
                _minLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinLengthSpecified { get; set; }

        protected bool? _sendPermanentLockoutNotification;

        [XmlElement(ElementName = "sendPermanentLockoutNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? SendPermanentLockoutNotification
        {
            get => _sendPermanentLockoutNotification;
            set
            {
                SendPermanentLockoutNotificationSpecified = (value != null);
                _sendPermanentLockoutNotification = value;
            }
        }

        [XmlIgnore]
        protected bool SendPermanentLockoutNotificationSpecified { get; set; }

        protected string _permanentLockoutNotifyEmailAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "permanentLockoutNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PermanentLockoutNotifyEmailAddress
        {
            get => _permanentLockoutNotifyEmailAddress;
            set
            {
                PermanentLockoutNotifyEmailAddressSpecified = true;
                _permanentLockoutNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PermanentLockoutNotifyEmailAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? _deviceProfileAuthenticationLockoutType;

        [XmlElement(ElementName = "deviceProfileAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? DeviceProfileAuthenticationLockoutType
        {
            get => _deviceProfileAuthenticationLockoutType;
            set
            {
                DeviceProfileAuthenticationLockoutTypeSpecified = (value != null);
                _deviceProfileAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileAuthenticationLockoutTypeSpecified { get; set; }

        protected int? _deviceProfileTemporaryLockoutThreshold;

        [XmlElement(ElementName = "deviceProfileTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? DeviceProfileTemporaryLockoutThreshold
        {
            get => _deviceProfileTemporaryLockoutThreshold;
            set
            {
                DeviceProfileTemporaryLockoutThresholdSpecified = (value != null);
                _deviceProfileTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileTemporaryLockoutThresholdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? _deviceProfileWaitAlgorithm;

        [XmlElement(ElementName = "deviceProfileWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? DeviceProfileWaitAlgorithm
        {
            get => _deviceProfileWaitAlgorithm;
            set
            {
                DeviceProfileWaitAlgorithmSpecified = (value != null);
                _deviceProfileWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileWaitAlgorithmSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? _deviceProfileLockoutFixedMinutes;

        [XmlElement(ElementName = "deviceProfileLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? DeviceProfileLockoutFixedMinutes
        {
            get => _deviceProfileLockoutFixedMinutes;
            set
            {
                DeviceProfileLockoutFixedMinutesSpecified = (value != null);
                _deviceProfileLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileLockoutFixedMinutesSpecified { get; set; }

        protected int? _deviceProfilePermanentLockoutThreshold;

        [XmlElement(ElementName = "deviceProfilePermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int? DeviceProfilePermanentLockoutThreshold
        {
            get => _deviceProfilePermanentLockoutThreshold;
            set
            {
                DeviceProfilePermanentLockoutThresholdSpecified = (value != null);
                _deviceProfilePermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfilePermanentLockoutThresholdSpecified { get; set; }

        protected bool? _usePasswordValidationService;

        [XmlElement(ElementName = "usePasswordValidationService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3197")]
        public bool? UsePasswordValidationService
        {
            get => _usePasswordValidationService;
            set
            {
                UsePasswordValidationServiceSpecified = (value != null);
                _usePasswordValidationService = value;
            }
        }

        [XmlIgnore]
        protected bool UsePasswordValidationServiceSpecified { get; set; }

    }
}
