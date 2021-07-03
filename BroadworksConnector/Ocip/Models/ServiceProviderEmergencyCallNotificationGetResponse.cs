using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEmergencyCallNotificationGetRequest.
    /// <see cref="ServiceProviderEmergencyCallNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4056""}]")]
    public class ServiceProviderEmergencyCallNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _sendEmergencyCallNotificationEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4056")]
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

        private string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4056")]
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

        private bool _allowGroupOverride;

        [XmlElement(ElementName = "allowGroupOverride", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4056")]
        public bool AllowGroupOverride
        {
            get => _allowGroupOverride;
            set
            {
                AllowGroupOverrideSpecified = true;
                _allowGroupOverride = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGroupOverrideSpecified { get; set; }

    }
}
