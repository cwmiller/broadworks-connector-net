using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Voice Messaging.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:567""}]")]
    public class SystemVoiceMessageSummaryUpdateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _sendSavedAndUrgentMWIOnNotification;

        [XmlElement(ElementName = "sendSavedAndUrgentMWIOnNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:567")]
        public bool SendSavedAndUrgentMWIOnNotification
        {
            get => _sendSavedAndUrgentMWIOnNotification;
            set
            {
                SendSavedAndUrgentMWIOnNotificationSpecified = true;
                _sendSavedAndUrgentMWIOnNotification = value;
            }
        }

        [XmlIgnore]
        public bool SendSavedAndUrgentMWIOnNotificationSpecified { get; set; }

        private bool _sendMessageSummaryUpdateOnRegister;

        [XmlElement(ElementName = "sendMessageSummaryUpdateOnRegister", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:567")]
        public bool SendMessageSummaryUpdateOnRegister
        {
            get => _sendMessageSummaryUpdateOnRegister;
            set
            {
                SendMessageSummaryUpdateOnRegisterSpecified = true;
                _sendMessageSummaryUpdateOnRegister = value;
            }
        }

        [XmlIgnore]
        public bool SendMessageSummaryUpdateOnRegisterSpecified { get; set; }

        private int _minTimeBetweenMWIOnRegister;

        [XmlElement(ElementName = "minTimeBetweenMWIOnRegister", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:567")]
        [MinInclusive(0)]
        [MaxInclusive(86400)]
        public int MinTimeBetweenMWIOnRegister
        {
            get => _minTimeBetweenMWIOnRegister;
            set
            {
                MinTimeBetweenMWIOnRegisterSpecified = true;
                _minTimeBetweenMWIOnRegister = value;
            }
        }

        [XmlIgnore]
        public bool MinTimeBetweenMWIOnRegisterSpecified { get; set; }

    }
}
