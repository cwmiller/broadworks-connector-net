using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The common push notification registration elements which supports encryption, if required.
    /// Elements encryptionKeyIdentifier, encryptionAlgorithm and channel are provided only when registration supports encryption.
    /// Their absence indicates that encryption is not supported.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4038""}]")]
    public class PushNotificationRegistrationData23
    {

        protected string _registrationId;

        [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string RegistrationId
        {
            get => _registrationId;
            set
            {
                RegistrationIdSpecified = true;
                _registrationId = value;
            }
        }

        [XmlIgnore]
        protected bool RegistrationIdSpecified { get; set; }

        protected string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationIdSpecified { get; set; }

        protected string _applicationVersion;

        [XmlElement(ElementName = "applicationVersion", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string ApplicationVersion
        {
            get => _applicationVersion;
            set
            {
                ApplicationVersionSpecified = true;
                _applicationVersion = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationVersionSpecified { get; set; }

        protected string _deviceOsType;

        [XmlElement(ElementName = "deviceOsType", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(128)]
        public string DeviceOsType
        {
            get => _deviceOsType;
            set
            {
                DeviceOsTypeSpecified = true;
                _deviceOsType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceOsTypeSpecified { get; set; }

        protected string _deviceVersion;

        [XmlElement(ElementName = "deviceVersion", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string DeviceVersion
        {
            get => _deviceVersion;
            set
            {
                DeviceVersionSpecified = true;
                _deviceVersion = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceVersionSpecified { get; set; }

        protected string _timestamp;

        [XmlElement(ElementName = "timestamp", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        public string Timestamp
        {
            get => _timestamp;
            set
            {
                TimestampSpecified = true;
                _timestamp = value;
            }
        }

        [XmlIgnore]
        protected bool TimestampSpecified { get; set; }

        protected string _pushNotificationClientVersion;

        [XmlElement(ElementName = "pushNotificationClientVersion", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(10)]
        public string PushNotificationClientVersion
        {
            get => _pushNotificationClientVersion;
            set
            {
                PushNotificationClientVersionSpecified = true;
                _pushNotificationClientVersion = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationClientVersionSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData23> _pushNotificationTokenData = new List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData23>();

        [XmlElement(ElementName = "pushNotificationTokenData", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        public List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData23> PushNotificationTokenData
        {
            get => _pushNotificationTokenData;
            set
            {
                PushNotificationTokenDataSpecified = true;
                _pushNotificationTokenData = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationTokenDataSpecified { get; set; }

        protected string _encryptionKeyIdentifier;

        [XmlElement(ElementName = "encryptionKeyIdentifier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(128)]
        public string EncryptionKeyIdentifier
        {
            get => _encryptionKeyIdentifier;
            set
            {
                EncryptionKeyIdentifierSpecified = true;
                _encryptionKeyIdentifier = value;
            }
        }

        [XmlIgnore]
        protected bool EncryptionKeyIdentifierSpecified { get; set; }

        protected string _encryptionAlgorithm;

        [XmlElement(ElementName = "encryptionAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(64)]
        public string EncryptionAlgorithm
        {
            get => _encryptionAlgorithm;
            set
            {
                EncryptionAlgorithmSpecified = true;
                _encryptionAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool EncryptionAlgorithmSpecified { get; set; }

        protected string _channel;

        [XmlElement(ElementName = "channel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4038")]
        [MinLength(1)]
        [MaxLength(64)]
        public string Channel
        {
            get => _channel;
            set
            {
                ChannelSpecified = true;
                _channel = value;
            }
        }

        [XmlIgnore]
        protected bool ChannelSpecified { get; set; }

    }
}
