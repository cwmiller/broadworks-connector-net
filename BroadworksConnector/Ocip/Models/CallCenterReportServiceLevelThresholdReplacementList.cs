using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of call center reporting service level threshold seconds that replaces a previously configured list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportServiceLevelThresholdReplacementList 
    {

        
        private List<int> _serviceLevelThresholdSeconds;

        [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false, Namespace = "")]
        public List<int> ServiceLevelThresholdSeconds {
            get => _serviceLevelThresholdSeconds;
            set {
                ServiceLevelThresholdSecondsSpecified = true;
                _serviceLevelThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelThresholdSecondsSpecified { get; set; }
        
    }
}
