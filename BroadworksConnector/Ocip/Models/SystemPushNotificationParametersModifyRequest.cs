using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify push notification system parameters.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15294""}]")]
    public class SystemPushNotificationParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _enforceAllowedApplicationList;

        [XmlElement(ElementName = "enforceAllowedApplicationList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15294")]
        public bool? EnforceAllowedApplicationList
        {
            get => _enforceAllowedApplicationList;
            set
            {
                EnforceAllowedApplicationListSpecified = (value != null);
                _enforceAllowedApplicationList = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceAllowedApplicationListSpecified { get; set; }

        protected int? _maximumRegistrationsPerUser;

        [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15294")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int? MaximumRegistrationsPerUser
        {
            get => _maximumRegistrationsPerUser;
            set
            {
                MaximumRegistrationsPerUserSpecified = (value != null);
                _maximumRegistrationsPerUser = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationsPerUserSpecified { get; set; }

        protected int? _maximumRegistrationAgeDays;

        [XmlElement(ElementName = "maximumRegistrationAgeDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15294")]
        [MinInclusive(30)]
        [MaxInclusive(120)]
        public int? MaximumRegistrationAgeDays
        {
            get => _maximumRegistrationAgeDays;
            set
            {
                MaximumRegistrationAgeDaysSpecified = (value != null);
                _maximumRegistrationAgeDays = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationAgeDaysSpecified { get; set; }

        protected int? _newCallTimeout;

        [XmlElement(ElementName = "newCallTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15294")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int? NewCallTimeout
        {
            get => _newCallTimeout;
            set
            {
                NewCallTimeoutSpecified = (value != null);
                _newCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool NewCallTimeoutSpecified { get; set; }

        protected int? _subscriptionEventsPerSecond;

        [XmlElement(ElementName = "subscriptionEventsPerSecond", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15294")]
        [MinInclusive(1)]
        [MaxInclusive(5000)]
        public int? SubscriptionEventsPerSecond
        {
            get => _subscriptionEventsPerSecond;
            set
            {
                SubscriptionEventsPerSecondSpecified = (value != null);
                _subscriptionEventsPerSecond = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriptionEventsPerSecondSpecified { get; set; }

    }
}
