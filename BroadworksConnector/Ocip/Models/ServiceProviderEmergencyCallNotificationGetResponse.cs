using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEmergencyCallNotificationGetRequest.
        /// <see cref="ServiceProviderEmergencyCallNotificationGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderEmergencyCallNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _sendEmergencyCallNotificationEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false, Namespace = "")]
        public bool SendEmergencyCallNotificationEmail {
            get => _sendEmergencyCallNotificationEmail;
            set {
                SendEmergencyCallNotificationEmailSpecified = true;
                _sendEmergencyCallNotificationEmail = value;
            }
        }

        [XmlIgnore]
        public bool SendEmergencyCallNotificationEmailSpecified { get; set; }
        
        private string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false, Namespace = "")]
        public string EmergencyCallNotifyEmailAddress {
            get => _emergencyCallNotifyEmailAddress;
            set {
                EmergencyCallNotifyEmailAddressSpecified = true;
                _emergencyCallNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyCallNotifyEmailAddressSpecified { get; set; }
        
        private bool _allowGroupOverride;

        [XmlElement(ElementName = "allowGroupOverride", IsNullable = false, Namespace = "")]
        public bool AllowGroupOverride {
            get => _allowGroupOverride;
            set {
                AllowGroupOverrideSpecified = true;
                _allowGroupOverride = value;
            }
        }

        [XmlIgnore]
        public bool AllowGroupOverrideSpecified { get; set; }
        
    }
}
