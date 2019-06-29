using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system level device profile authentication password rule settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7579""}]")]
    public class SystemDeviceProfileAuthenticationPasswordRulesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _disallowAuthenticationName;

        [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool DisallowAuthenticationName
        {
            get => _disallowAuthenticationName;
            set
            {
                DisallowAuthenticationNameSpecified = true;
                _disallowAuthenticationName = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowAuthenticationNameSpecified { get; set; }

        private bool _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool DisallowOldPassword
        {
            get => _disallowOldPassword;
            set
            {
                DisallowOldPasswordSpecified = true;
                _disallowOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowOldPasswordSpecified { get; set; }

        private bool _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool DisallowReversedOldPassword
        {
            get => _disallowReversedOldPassword;
            set
            {
                DisallowReversedOldPasswordSpecified = true;
                _disallowReversedOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedOldPasswordSpecified { get; set; }

        private bool _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool RestrictMinDigits
        {
            get => _restrictMinDigits;
            set
            {
                RestrictMinDigitsSpecified = true;
                _restrictMinDigits = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinDigitsSpecified { get; set; }

        private int _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinDigits
        {
            get => _minDigits;
            set
            {
                MinDigitsSpecified = true;
                _minDigits = value;
            }
        }

        [XmlIgnore]
        protected bool MinDigitsSpecified { get; set; }

        private bool _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool RestrictMinUpperCaseLetters
        {
            get => _restrictMinUpperCaseLetters;
            set
            {
                RestrictMinUpperCaseLettersSpecified = true;
                _restrictMinUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinUpperCaseLettersSpecified { get; set; }

        private int _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinUpperCaseLetters
        {
            get => _minUpperCaseLetters;
            set
            {
                MinUpperCaseLettersSpecified = true;
                _minUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinUpperCaseLettersSpecified { get; set; }

        private bool _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool RestrictMinLowerCaseLetters
        {
            get => _restrictMinLowerCaseLetters;
            set
            {
                RestrictMinLowerCaseLettersSpecified = true;
                _restrictMinLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinLowerCaseLettersSpecified { get; set; }

        private int _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinLowerCaseLetters
        {
            get => _minLowerCaseLetters;
            set
            {
                MinLowerCaseLettersSpecified = true;
                _minLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinLowerCaseLettersSpecified { get; set; }

        private bool _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool RestrictMinNonAlphanumericCharacters
        {
            get => _restrictMinNonAlphanumericCharacters;
            set
            {
                RestrictMinNonAlphanumericCharactersSpecified = true;
                _restrictMinNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        private int _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinNonAlphanumericCharacters
        {
            get => _minNonAlphanumericCharacters;
            set
            {
                MinNonAlphanumericCharactersSpecified = true;
                _minNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool MinNonAlphanumericCharactersSpecified { get; set; }

        private int _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(3)]
        [MaxInclusive(40)]
        public int MinLength
        {
            get => _minLength;
            set
            {
                MinLengthSpecified = true;
                _minLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinLengthSpecified { get; set; }

        private bool _sendPermanentLockoutNotification;

        [XmlElement(ElementName = "sendPermanentLockoutNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public bool SendPermanentLockoutNotification
        {
            get => _sendPermanentLockoutNotification;
            set
            {
                SendPermanentLockoutNotificationSpecified = true;
                _sendPermanentLockoutNotification = value;
            }
        }

        [XmlIgnore]
        protected bool SendPermanentLockoutNotificationSpecified { get; set; }

        private string _permanentLockoutNotifyEmailAddress;

        [XmlElement(ElementName = "permanentLockoutNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
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

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutType _deviceProfileAuthenticationLockoutType;

        [XmlElement(ElementName = "deviceProfileAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType DeviceProfileAuthenticationLockoutType
        {
            get => _deviceProfileAuthenticationLockoutType;
            set
            {
                DeviceProfileAuthenticationLockoutTypeSpecified = true;
                _deviceProfileAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileAuthenticationLockoutTypeSpecified { get; set; }

        private int _deviceProfileTemporaryLockoutThreshold;

        [XmlElement(ElementName = "deviceProfileTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int DeviceProfileTemporaryLockoutThreshold
        {
            get => _deviceProfileTemporaryLockoutThreshold;
            set
            {
                DeviceProfileTemporaryLockoutThresholdSpecified = true;
                _deviceProfileTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileTemporaryLockoutThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType _deviceProfileWaitAlgorithm;

        [XmlElement(ElementName = "deviceProfileWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType DeviceProfileWaitAlgorithm
        {
            get => _deviceProfileWaitAlgorithm;
            set
            {
                DeviceProfileWaitAlgorithmSpecified = true;
                _deviceProfileWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileWaitAlgorithmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes _deviceProfileLockoutFixedMinutes;

        [XmlElement(ElementName = "deviceProfileLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes DeviceProfileLockoutFixedMinutes
        {
            get => _deviceProfileLockoutFixedMinutes;
            set
            {
                DeviceProfileLockoutFixedMinutesSpecified = true;
                _deviceProfileLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfileLockoutFixedMinutesSpecified { get; set; }

        private int _deviceProfilePermanentLockoutThreshold;

        [XmlElement(ElementName = "deviceProfilePermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7579")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int DeviceProfilePermanentLockoutThreshold
        {
            get => _deviceProfilePermanentLockoutThreshold;
            set
            {
                DeviceProfilePermanentLockoutThresholdSpecified = true;
                _deviceProfilePermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceProfilePermanentLockoutThresholdSpecified { get; set; }

    }
}
