using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of call center reporting service level threshold seconds that replaces a previously configured list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7523""}]")]
    public class CallCenterReportServiceLevelThresholdReplacementList
    {

        private List<int> _serviceLevelThresholdSeconds = new List<int>();

        [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7523")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public List<int> ServiceLevelThresholdSeconds
        {
            get => _serviceLevelThresholdSeconds;
            set
            {
                ServiceLevelThresholdSecondsSpecified = true;
                _serviceLevelThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelThresholdSecondsSpecified { get; set; }

    }
}
