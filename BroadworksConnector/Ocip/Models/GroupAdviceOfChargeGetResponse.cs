using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAdviceOfChargeGetRequest.
    /// Contains a list of Advice of Charge group parameters.
    /// <see cref="GroupAdviceOfChargeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:68""}]")]
    public class GroupAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useGroupLevelAoCSettings;

        [XmlElement(ElementName = "useGroupLevelAoCSettings", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:68")]
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
        protected bool UseGroupLevelAoCSettingsSpecified { get; set; }

        protected int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:68")]
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
