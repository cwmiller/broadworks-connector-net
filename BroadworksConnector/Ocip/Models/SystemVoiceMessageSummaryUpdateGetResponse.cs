using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVoiceMessageSummaryUpdateGetRequest.
    /// 
    /// Replaced By: SystemVoiceMessageSummaryUpdateGetResponse25
    /// <see cref="SystemVoiceMessageSummaryUpdateGetRequest"/>
    /// <see cref="SystemVoiceMessageSummaryUpdateGetResponse25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36770""}]")]
    public class SystemVoiceMessageSummaryUpdateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _sendSavedAndUrgentMWIOnNotification;

        [XmlElement(ElementName = "sendSavedAndUrgentMWIOnNotification", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:36770")]
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
        protected bool SendSavedAndUrgentMWIOnNotificationSpecified { get; set; }

        protected bool _sendMessageSummaryUpdateOnRegister;

        [XmlElement(ElementName = "sendMessageSummaryUpdateOnRegister", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:36770")]
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
        protected bool SendMessageSummaryUpdateOnRegisterSpecified { get; set; }

        protected int _minTimeBetweenMWIOnRegister;

        [XmlElement(ElementName = "minTimeBetweenMWIOnRegister", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:36770")]
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
        protected bool MinTimeBetweenMWIOnRegisterSpecified { get; set; }

    }
}
