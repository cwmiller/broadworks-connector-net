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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:120""}]")]
    public class ServiceProviderAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useSPLevelAoCSettings;

        [XmlElement(ElementName = "useSPLevelAoCSettings", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:120")]
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
        protected bool UseSPLevelAoCSettingsSpecified { get; set; }

        protected int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:120")]
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
        protected bool DelayBetweenNotificationSecondsSpecified { get; set; }

    }
}
