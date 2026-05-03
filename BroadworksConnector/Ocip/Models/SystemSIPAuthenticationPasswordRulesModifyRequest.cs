using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system level SIP authentication password rule settings
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17083""}]")]
    public class SystemSIPAuthenticationPasswordRulesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _disallowAuthenticationName;

        [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? _endpointAuthenticationLockoutType;

        [XmlElement(ElementName = "endpointAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? EndpointAuthenticationLockoutType
        {
            get => _endpointAuthenticationLockoutType;
            set
            {
                EndpointAuthenticationLockoutTypeSpecified = (value != null);
                _endpointAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointAuthenticationLockoutTypeSpecified { get; set; }

        protected int? _endpointTemporaryLockoutThreshold;

        [XmlElement(ElementName = "endpointTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? EndpointTemporaryLockoutThreshold
        {
            get => _endpointTemporaryLockoutThreshold;
            set
            {
                EndpointTemporaryLockoutThresholdSpecified = (value != null);
                _endpointTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTemporaryLockoutThresholdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? _endpointWaitAlgorithm;

        [XmlElement(ElementName = "endpointWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? EndpointWaitAlgorithm
        {
            get => _endpointWaitAlgorithm;
            set
            {
                EndpointWaitAlgorithmSpecified = (value != null);
                _endpointWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointWaitAlgorithmSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? _endpointLockoutFixedMinutes;

        [XmlElement(ElementName = "endpointLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? EndpointLockoutFixedMinutes
        {
            get => _endpointLockoutFixedMinutes;
            set
            {
                EndpointLockoutFixedMinutesSpecified = (value != null);
                _endpointLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointLockoutFixedMinutesSpecified { get; set; }

        protected int? _endpointPermanentLockoutThreshold;

        [XmlElement(ElementName = "endpointPermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int? EndpointPermanentLockoutThreshold
        {
            get => _endpointPermanentLockoutThreshold;
            set
            {
                EndpointPermanentLockoutThresholdSpecified = (value != null);
                _endpointPermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointPermanentLockoutThresholdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? _trunkGroupAuthenticationLockoutType;

        [XmlElement(ElementName = "trunkGroupAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType? TrunkGroupAuthenticationLockoutType
        {
            get => _trunkGroupAuthenticationLockoutType;
            set
            {
                TrunkGroupAuthenticationLockoutTypeSpecified = (value != null);
                _trunkGroupAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupAuthenticationLockoutTypeSpecified { get; set; }

        protected int? _trunkGroupTemporaryLockoutThreshold;

        [XmlElement(ElementName = "trunkGroupTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? TrunkGroupTemporaryLockoutThreshold
        {
            get => _trunkGroupTemporaryLockoutThreshold;
            set
            {
                TrunkGroupTemporaryLockoutThresholdSpecified = (value != null);
                _trunkGroupTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupTemporaryLockoutThresholdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? _trunkGroupWaitAlgorithm;

        [XmlElement(ElementName = "trunkGroupWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType? TrunkGroupWaitAlgorithm
        {
            get => _trunkGroupWaitAlgorithm;
            set
            {
                TrunkGroupWaitAlgorithmSpecified = (value != null);
                _trunkGroupWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupWaitAlgorithmSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? _trunkGroupLockoutFixedMinutes;

        [XmlElement(ElementName = "trunkGroupLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes? TrunkGroupLockoutFixedMinutes
        {
            get => _trunkGroupLockoutFixedMinutes;
            set
            {
                TrunkGroupLockoutFixedMinutesSpecified = (value != null);
                _trunkGroupLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupLockoutFixedMinutesSpecified { get; set; }

        protected int? _trunkGroupPermanentLockoutThreshold;

        [XmlElement(ElementName = "trunkGroupPermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int? TrunkGroupPermanentLockoutThreshold
        {
            get => _trunkGroupPermanentLockoutThreshold;
            set
            {
                TrunkGroupPermanentLockoutThresholdSpecified = (value != null);
                _trunkGroupPermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupPermanentLockoutThresholdSpecified { get; set; }

        protected bool? _usePasswordValidationService;

        [XmlElement(ElementName = "usePasswordValidationService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17083")]
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
