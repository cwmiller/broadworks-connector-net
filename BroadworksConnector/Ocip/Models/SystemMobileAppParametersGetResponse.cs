using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMobileAppParametersGetRequest.
    /// 
    /// Contains a list of system mobile app parameters.
    /// <see cref="SystemMobileAppParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12485""}]")]
    public class SystemMobileAppParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maximumRegistrationTtlInMinutes;

        [XmlElement(ElementName = "maximumRegistrationTtlInMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12485")]
        [MinInclusive(1)]
        [MaxInclusive(172800)]
        public int MaximumRegistrationTtlInMinutes
        {
            get => _maximumRegistrationTtlInMinutes;
            set
            {
                MaximumRegistrationTtlInMinutesSpecified = true;
                _maximumRegistrationTtlInMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationTtlInMinutesSpecified { get; set; }

        protected int _callNotificationTimeoutInSeconds;

        [XmlElement(ElementName = "callNotificationTimeoutInSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12485")]
        [MinInclusive(1)]
        [MaxInclusive(180)]
        public int CallNotificationTimeoutInSeconds
        {
            get => _callNotificationTimeoutInSeconds;
            set
            {
                CallNotificationTimeoutInSecondsSpecified = true;
                _callNotificationTimeoutInSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CallNotificationTimeoutInSecondsSpecified { get; set; }

        protected int _maximumRegistrationsPerUser;

        [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12485")]
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

    }
}
