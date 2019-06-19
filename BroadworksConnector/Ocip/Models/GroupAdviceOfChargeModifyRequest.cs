using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider level Advice Of Charge group settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:85""}]")]
    public class GroupAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:85")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:85")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private bool _useGroupLevelAoCSettings;

        [XmlElement(ElementName = "useGroupLevelAoCSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:85")]
        public bool UseGroupLevelAoCSettings
        {
            get => _useGroupLevelAoCSettings;
            set
            {
                UseGroupLevelAoCSettingsSpecified = true;
                _useGroupLevelAoCSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupLevelAoCSettingsSpecified { get; set; }

        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:85")]
        [MinInclusive(5)]
        [MaxInclusive(1800)]
        public int DelayBetweenNotificationSeconds
        {
            get => _delayBetweenNotificationSeconds;
            set
            {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenNotificationSecondsSpecified { get; set; }

    }
}
