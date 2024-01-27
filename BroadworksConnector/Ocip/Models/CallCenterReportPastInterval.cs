using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting report past interval, for example, last 24 month.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7479""}]")]
    public class CallCenterReportPastInterval
    {

        protected int _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7479")]
        [MinInclusive(1)]
        [MaxInclusive(99)]
        public int Number
        {
            get => _number;
            set
            {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        protected bool NumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

        [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7479")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit TimeUnit
        {
            get => _timeUnit;
            set
            {
                TimeUnitSpecified = true;
                _timeUnit = value;
            }
        }

        [XmlIgnore]
        protected bool TimeUnitSpecified { get; set; }

    }
}
