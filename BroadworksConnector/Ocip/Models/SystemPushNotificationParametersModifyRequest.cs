using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify push notification system parameters.
    /// 
    /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
    /// subscriptionEventsPerSecond
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPushNotificationParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
