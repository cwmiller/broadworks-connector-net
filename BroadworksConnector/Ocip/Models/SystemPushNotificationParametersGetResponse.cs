using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPushNotificationParametersGetRequest.
    /// 
    /// The following elements are only used in AS data mode:
    /// subscriptionEventsPerSecond, value "100" is returned in Amplify data mode.
    /// 
    /// Contains a list of system push notification parameters.
        /// <see cref="SystemPushNotificationParametersGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPushNotificationParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enforceAllowedApplicationList;

        [XmlElement(ElementName = "enforceAllowedApplicationList", IsNullable = false, Namespace = "")]
        public bool EnforceAllowedApplicationList {
            get => _enforceAllowedApplicationList;
            set {
                EnforceAllowedApplicationListSpecified = true;
                _enforceAllowedApplicationList = value;
            }
        }

        [XmlIgnore]
        public bool EnforceAllowedApplicationListSpecified { get; set; }
        
        private int _maximumRegistrationsPerUser;

        [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false, Namespace = "")]
        public int MaximumRegistrationsPerUser {
            get => _maximumRegistrationsPerUser;
            set {
                MaximumRegistrationsPerUserSpecified = true;
                _maximumRegistrationsPerUser = value;
            }
        }

        [XmlIgnore]
        public bool MaximumRegistrationsPerUserSpecified { get; set; }
        
        private int _maximumRegistrationAgeDays;

        [XmlElement(ElementName = "maximumRegistrationAgeDays", IsNullable = false, Namespace = "")]
        public int MaximumRegistrationAgeDays {
            get => _maximumRegistrationAgeDays;
            set {
                MaximumRegistrationAgeDaysSpecified = true;
                _maximumRegistrationAgeDays = value;
            }
        }

        [XmlIgnore]
        public bool MaximumRegistrationAgeDaysSpecified { get; set; }
        
        private int _newCallTimeout;

        [XmlElement(ElementName = "newCallTimeout", IsNullable = false, Namespace = "")]
        public int NewCallTimeout {
            get => _newCallTimeout;
            set {
                NewCallTimeoutSpecified = true;
                _newCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool NewCallTimeoutSpecified { get; set; }
        
        private int _subscriptionEventsPerSecond;

        [XmlElement(ElementName = "subscriptionEventsPerSecond", IsNullable = false, Namespace = "")]
        public int SubscriptionEventsPerSecond {
            get => _subscriptionEventsPerSecond;
            set {
                SubscriptionEventsPerSecondSpecified = true;
                _subscriptionEventsPerSecond = value;
            }
        }

        [XmlIgnore]
        public bool SubscriptionEventsPerSecondSpecified { get; set; }
        
    }
}
