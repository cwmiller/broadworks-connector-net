using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterGetRequest14sp9.
    /// <see cref="SystemCallCenterGetRequest14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9997""}]")]
    public class SystemCallCenterGetResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9997")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes _statisticsSamplingPeriodMinutes;

        [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9997")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes
        {
            get => _statisticsSamplingPeriodMinutes;
            set
            {
                StatisticsSamplingPeriodMinutesSpecified = true;
                _statisticsSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsSamplingPeriodMinutesSpecified { get; set; }

    }
}
