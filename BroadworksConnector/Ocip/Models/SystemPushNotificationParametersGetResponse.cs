using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13753""}]")]
    public class SystemPushNotificationParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enforceAllowedApplicationList;

        [XmlElement(ElementName = "enforceAllowedApplicationList", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13753")]
        public bool EnforceAllowedApplicationList
        {
            get => _enforceAllowedApplicationList;
            set
            {
                EnforceAllowedApplicationListSpecified = true;
                _enforceAllowedApplicationList = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceAllowedApplicationListSpecified { get; set; }

        private int _maximumRegistrationsPerUser;

        [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13753")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaximumRegistrationsPerUser
        {
            get => _maximumRegistrationsPerUser;
            set
            {
                MaximumRegistrationsPerUserSpecified = true;
                _maximumRegistrationsPerUser = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationsPerUserSpecified { get; set; }

        private int _maximumRegistrationAgeDays;

        [XmlElement(ElementName = "maximumRegistrationAgeDays", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13753")]
        [MinInclusive(30)]
        [MaxInclusive(120)]
        public int MaximumRegistrationAgeDays
        {
            get => _maximumRegistrationAgeDays;
            set
            {
                MaximumRegistrationAgeDaysSpecified = true;
                _maximumRegistrationAgeDays = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationAgeDaysSpecified { get; set; }

        private int _newCallTimeout;

        [XmlElement(ElementName = "newCallTimeout", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13753")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int NewCallTimeout
        {
            get => _newCallTimeout;
            set
            {
                NewCallTimeoutSpecified = true;
                _newCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool NewCallTimeoutSpecified { get; set; }

        private int _subscriptionEventsPerSecond;

        [XmlElement(ElementName = "subscriptionEventsPerSecond", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13753")]
        [MinInclusive(1)]
        [MaxInclusive(5000)]
        public int SubscriptionEventsPerSecond
        {
            get => _subscriptionEventsPerSecond;
            set
            {
                SubscriptionEventsPerSecondSpecified = true;
                _subscriptionEventsPerSecond = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriptionEventsPerSecondSpecified { get; set; }

    }
}
