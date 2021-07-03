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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7493""}]")]
    public class CallCenterReportPastInterval
    {

        private int _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7493")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

        [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7493")]
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
