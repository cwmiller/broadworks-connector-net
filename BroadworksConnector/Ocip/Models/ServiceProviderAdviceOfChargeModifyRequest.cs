using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider level Advice Of Charge service provider settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private bool _useSPLevelAoCSettings;

        [XmlElement(ElementName = "useSPLevelAoCSettings", IsNullable = false, Namespace = "")]
        public bool UseSPLevelAoCSettings {
            get => _useSPLevelAoCSettings;
            set {
                UseSPLevelAoCSettingsSpecified = true;
                _useSPLevelAoCSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseSPLevelAoCSettingsSpecified { get; set; }
        
        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        public int DelayBetweenNotificationSeconds {
            get => _delayBetweenNotificationSeconds;
            set {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenNotificationSecondsSpecified { get; set; }
        
    }
}
