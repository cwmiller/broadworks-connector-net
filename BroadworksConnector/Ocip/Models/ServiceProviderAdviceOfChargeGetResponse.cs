using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdviceOfChargeGetRequest.
    /// Contains a list of Advice of Charge service provider parameters.
    /// <see cref="ServiceProviderAdviceOfChargeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:120""}]")]
    public class ServiceProviderAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useSPLevelAoCSettings;

        [XmlElement(ElementName = "useSPLevelAoCSettings", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:120")]
        public bool UseSPLevelAoCSettings
        {
            get => _useSPLevelAoCSettings;
            set
            {
                UseSPLevelAoCSettingsSpecified = true;
                _useSPLevelAoCSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseSPLevelAoCSettingsSpecified { get; set; }

        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:120")]
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
