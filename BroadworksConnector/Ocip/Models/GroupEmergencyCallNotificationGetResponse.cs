using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEmergencyCallNotificationGetRequest.
    /// <see cref="GroupEmergencyCallNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5293""}]")]
    public class GroupEmergencyCallNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _sendEmergencyCallNotificationEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5293")]
        public bool SendEmergencyCallNotificationEmail
        {
            get => _sendEmergencyCallNotificationEmail;
            set
            {
                SendEmergencyCallNotificationEmailSpecified = true;
                _sendEmergencyCallNotificationEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmergencyCallNotificationEmailSpecified { get; set; }

        protected string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5293")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmergencyCallNotifyEmailAddress
        {
            get => _emergencyCallNotifyEmailAddress;
            set
            {
                EmergencyCallNotifyEmailAddressSpecified = true;
                _emergencyCallNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallNotifyEmailAddressSpecified { get; set; }

    }
}
