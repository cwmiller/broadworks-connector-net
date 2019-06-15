using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center Queue statistics.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterQueueStatistics13mp8 
    {

        
        private int _numberOfIncomingCalls;

        [XmlElement(ElementName = "numberOfIncomingCalls", IsNullable = false, Namespace = "")]
        public int NumberOfIncomingCalls {
            get => _numberOfIncomingCalls;
            set {
                NumberOfIncomingCallsSpecified = true;
                _numberOfIncomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfIncomingCallsSpecified { get; set; }
        
        private int _numberOfCallsQueued;

        [XmlElement(ElementName = "numberOfCallsQueued", IsNullable = false, Namespace = "")]
        public int NumberOfCallsQueued {
            get => _numberOfCallsQueued;
            set {
                NumberOfCallsQueuedSpecified = true;
                _numberOfCallsQueued = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfCallsQueuedSpecified { get; set; }
        
        private int _numberOfBusyOverflows;

        [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false, Namespace = "")]
        public int NumberOfBusyOverflows {
            get => _numberOfBusyOverflows;
            set {
                NumberOfBusyOverflowsSpecified = true;
                _numberOfBusyOverflows = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfBusyOverflowsSpecified { get; set; }
        
        private int _numberOfCallsAnswered;

        [XmlElement(ElementName = "numberOfCallsAnswered", IsNullable = false, Namespace = "")]
        public int NumberOfCallsAnswered {
            get => _numberOfCallsAnswered;
            set {
                NumberOfCallsAnsweredSpecified = true;
                _numberOfCallsAnswered = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfCallsAnsweredSpecified { get; set; }
        
        private int _averageTimeWithAgentSeconds;

        [XmlElement(ElementName = "averageTimeWithAgentSeconds", IsNullable = false, Namespace = "")]
        public int AverageTimeWithAgentSeconds {
            get => _averageTimeWithAgentSeconds;
            set {
                AverageTimeWithAgentSecondsSpecified = true;
                _averageTimeWithAgentSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AverageTimeWithAgentSecondsSpecified { get; set; }
        
        private int _averageTimeInQueueSeconds;

        [XmlElement(ElementName = "averageTimeInQueueSeconds", IsNullable = false, Namespace = "")]
        public int AverageTimeInQueueSeconds {
            get => _averageTimeInQueueSeconds;
            set {
                AverageTimeInQueueSecondsSpecified = true;
                _averageTimeInQueueSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AverageTimeInQueueSecondsSpecified { get; set; }
        
        private string _averageNumberOfAgentsBusy;

        [XmlElement(ElementName = "averageNumberOfAgentsBusy", IsNullable = false, Namespace = "")]
        public string AverageNumberOfAgentsBusy {
            get => _averageNumberOfAgentsBusy;
            set {
                AverageNumberOfAgentsBusySpecified = true;
                _averageNumberOfAgentsBusy = value;
            }
        }

        [XmlIgnore]
        public bool AverageNumberOfAgentsBusySpecified { get; set; }
        
        private string _averageNumberOfAgentsLoggedOff;

        [XmlElement(ElementName = "averageNumberOfAgentsLoggedOff", IsNullable = false, Namespace = "")]
        public string AverageNumberOfAgentsLoggedOff {
            get => _averageNumberOfAgentsLoggedOff;
            set {
                AverageNumberOfAgentsLoggedOffSpecified = true;
                _averageNumberOfAgentsLoggedOff = value;
            }
        }

        [XmlIgnore]
        public bool AverageNumberOfAgentsLoggedOffSpecified { get; set; }
        
        private int _averageHoldTimeBeforeCallLossSeconds;

        [XmlElement(ElementName = "averageHoldTimeBeforeCallLossSeconds", IsNullable = false, Namespace = "")]
        public int AverageHoldTimeBeforeCallLossSeconds {
            get => _averageHoldTimeBeforeCallLossSeconds;
            set {
                AverageHoldTimeBeforeCallLossSecondsSpecified = true;
                _averageHoldTimeBeforeCallLossSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AverageHoldTimeBeforeCallLossSecondsSpecified { get; set; }
        
    }
}
