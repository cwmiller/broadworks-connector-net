using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting scheduled report modified inclusions related to the Service Level thresholds
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterScheduledReportServiceLevelInclusionsModify 
    {

        
        private bool _includeOverflowTimeTransferedInServiceLevel;

        [XmlElement(ElementName = "includeOverflowTimeTransferedInServiceLevel", IsNullable = false, Namespace = "")]
        public bool IncludeOverflowTimeTransferedInServiceLevel {
            get => _includeOverflowTimeTransferedInServiceLevel;
            set {
                IncludeOverflowTimeTransferedInServiceLevelSpecified = true;
                _includeOverflowTimeTransferedInServiceLevel = value;
            }
        }

        [XmlIgnore]
        public bool IncludeOverflowTimeTransferedInServiceLevelSpecified { get; set; }
        
        private bool _includeOtherTransfersInServiceLevel;

        [XmlElement(ElementName = "includeOtherTransfersInServiceLevel", IsNullable = false, Namespace = "")]
        public bool IncludeOtherTransfersInServiceLevel {
            get => _includeOtherTransfersInServiceLevel;
            set {
                IncludeOtherTransfersInServiceLevelSpecified = true;
                _includeOtherTransfersInServiceLevel = value;
            }
        }

        [XmlIgnore]
        public bool IncludeOtherTransfersInServiceLevelSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportAbadonedCallsInServiceLevel _abandonedCallsInServiceLevel;

        [XmlElement(ElementName = "abandonedCallsInServiceLevel", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportAbadonedCallsInServiceLevel AbandonedCallsInServiceLevel {
            get => _abandonedCallsInServiceLevel;
            set {
                AbandonedCallsInServiceLevelSpecified = true;
                _abandonedCallsInServiceLevel = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallsInServiceLevelSpecified { get; set; }
        
        private int? _abandonedCallIntervalSeconds;

        [XmlElement(ElementName = "abandonedCallIntervalSeconds", IsNullable = true, Namespace = "")]
        public int? AbandonedCallIntervalSeconds {
            get => _abandonedCallIntervalSeconds;
            set {
                AbandonedCallIntervalSecondsSpecified = true;
                _abandonedCallIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallIntervalSecondsSpecified { get; set; }
        
    }
}
