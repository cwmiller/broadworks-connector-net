using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVoiceMessageSummaryUpdateGetRequest25.
    /// <see cref="SystemVoiceMessageSummaryUpdateGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:549""}]")]
    public class SystemVoiceMessageSummaryUpdateGetResponse25 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _sendSavedAndUrgentMWIOnNotification;

        [XmlElement(ElementName = "sendSavedAndUrgentMWIOnNotification", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:549")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:549")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:549")]
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

        protected bool _allowMultipleUsersPerAccount;

        [XmlElement(ElementName = "allowMultipleUsersPerAccount", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:549")]
        public bool AllowMultipleUsersPerAccount
        {
            get => _allowMultipleUsersPerAccount;
            set
            {
                AllowMultipleUsersPerAccountSpecified = true;
                _allowMultipleUsersPerAccount = value;
            }
        }

        [XmlIgnore]
        protected bool AllowMultipleUsersPerAccountSpecified { get; set; }

    }
}
