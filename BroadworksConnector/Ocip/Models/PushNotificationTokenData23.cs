using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The common push notification token elements.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4059""}]")]
    public class PushNotificationTokenData23
    {

        protected string _pushNotificationToken;

        [XmlElement(ElementName = "pushNotificationToken", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4059")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PushNotificationToken
        {
            get => _pushNotificationToken;
            set
            {
                PushNotificationTokenSpecified = true;
                _pushNotificationToken = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationTokenSpecified { get; set; }

        protected string _pushNotificationType;

        [XmlElement(ElementName = "pushNotificationType", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4059")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PushNotificationType
        {
            get => _pushNotificationType;
            set
            {
                PushNotificationTypeSpecified = true;
                _pushNotificationType = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.PushNotificationEventData23> _pushNotificationEventData = new List<BroadWorksConnector.Ocip.Models.PushNotificationEventData23>();

        [XmlElement(ElementName = "pushNotificationEventData", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4059")]
        public List<BroadWorksConnector.Ocip.Models.PushNotificationEventData23> PushNotificationEventData
        {
            get => _pushNotificationEventData;
            set
            {
                PushNotificationEventDataSpecified = true;
                _pushNotificationEventData = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationEventDataSpecified { get; set; }

    }
}
