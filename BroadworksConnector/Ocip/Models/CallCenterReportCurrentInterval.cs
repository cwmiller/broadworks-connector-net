using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting report current interval, for example, current week.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7387""}]")]
    public class CallCenterReportCurrentInterval
    {

        private BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

        [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7387")]
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
