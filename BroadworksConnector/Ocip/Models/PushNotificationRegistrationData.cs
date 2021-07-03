using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// ?
    /// The common push notification registration elements.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3552""}]")]
    public class PushNotificationRegistrationData
    {

        private string _registrationId;

        [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _applicationVersion;

        [XmlElement(ElementName = "applicationVersion", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _deviceOsType;

        [XmlElement(ElementName = "deviceOsType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _deviceVersion;

        [XmlElement(ElementName = "deviceVersion", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _timestamp;

        [XmlElement(ElementName = "timestamp", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private string _pushNotificationClientVersion;

        [XmlElement(ElementName = "pushNotificationClientVersion", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
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

        private List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData> _pushNotificationTokenData = new List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData>();

        [XmlElement(ElementName = "pushNotificationTokenData", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3552")]
        public List<BroadWorksConnector.Ocip.Models.PushNotificationTokenData> PushNotificationTokenData
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

    }
}
