using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify mobile app system parameters.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12504""}]")]
    public class SystemMobileAppParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int? _maximumRegistrationTtlInMinutes;

        [XmlElement(ElementName = "maximumRegistrationTtlInMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12504")]
        [MinInclusive(1)]
        [MaxInclusive(172800)]
        public int? MaximumRegistrationTtlInMinutes
        {
            get => _maximumRegistrationTtlInMinutes;
            set
            {
                MaximumRegistrationTtlInMinutesSpecified = (value != null);
                _maximumRegistrationTtlInMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRegistrationTtlInMinutesSpecified { get; set; }

        protected int? _callNotificationTimeoutInSeconds;

        [XmlElement(ElementName = "callNotificationTimeoutInSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12504")]
        [MinInclusive(1)]
        [MaxInclusive(180)]
        public int? CallNotificationTimeoutInSeconds
        {
            get => _callNotificationTimeoutInSeconds;
            set
            {
                CallNotificationTimeoutInSecondsSpecified = (value != null);
                _callNotificationTimeoutInSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CallNotificationTimeoutInSecondsSpecified { get; set; }

        protected int? _maximumRegistrationsPerUser;

        [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12504")]
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

    }
}
