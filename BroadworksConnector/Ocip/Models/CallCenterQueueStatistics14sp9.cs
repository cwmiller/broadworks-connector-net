using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center Queue statistics.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7353""}]")]
    public class CallCenterQueueStatistics14sp9
    {

        protected int _numberOfBusyOverflows;

        [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int NumberOfBusyOverflows
        {
            get => _numberOfBusyOverflows;
            set
            {
                NumberOfBusyOverflowsSpecified = true;
                _numberOfBusyOverflows = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfBusyOverflowsSpecified { get; set; }

        protected int _numberOfCallsAnswered;

        [XmlElement(ElementName = "numberOfCallsAnswered", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int NumberOfCallsAnswered
        {
            get => _numberOfCallsAnswered;
            set
            {
                NumberOfCallsAnsweredSpecified = true;
                _numberOfCallsAnswered = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsAnsweredSpecified { get; set; }

        protected int _numberOfCallsAbandoned;

        [XmlElement(ElementName = "numberOfCallsAbandoned", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int NumberOfCallsAbandoned
        {
            get => _numberOfCallsAbandoned;
            set
            {
                NumberOfCallsAbandonedSpecified = true;
                _numberOfCallsAbandoned = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsAbandonedSpecified { get; set; }

        protected int _numberOfCallsTransferred;

        [XmlElement(ElementName = "numberOfCallsTransferred", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int NumberOfCallsTransferred
        {
            get => _numberOfCallsTransferred;
            set
            {
                NumberOfCallsTransferredSpecified = true;
                _numberOfCallsTransferred = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsTransferredSpecified { get; set; }

        protected int _numberOfCallsTimedout;

        [XmlElement(ElementName = "numberOfCallsTimedout", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int NumberOfCallsTimedout
        {
            get => _numberOfCallsTimedout;
            set
            {
                NumberOfCallsTimedoutSpecified = true;
                _numberOfCallsTimedout = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsTimedoutSpecified { get; set; }

        protected string _averageNumberOfAgentsTalking;

        [XmlElement(ElementName = "averageNumberOfAgentsTalking", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public string AverageNumberOfAgentsTalking
        {
            get => _averageNumberOfAgentsTalking;
            set
            {
                AverageNumberOfAgentsTalkingSpecified = true;
                _averageNumberOfAgentsTalking = value;
            }
        }

        [XmlIgnore]
        protected bool AverageNumberOfAgentsTalkingSpecified { get; set; }

        protected string _averageNumberOfAgentsStaffed;

        [XmlElement(ElementName = "averageNumberOfAgentsStaffed", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public string AverageNumberOfAgentsStaffed
        {
            get => _averageNumberOfAgentsStaffed;
            set
            {
                AverageNumberOfAgentsStaffedSpecified = true;
                _averageNumberOfAgentsStaffed = value;
            }
        }

        [XmlIgnore]
        protected bool AverageNumberOfAgentsStaffedSpecified { get; set; }

        protected int _averageWaitSeconds;

        [XmlElement(ElementName = "averageWaitSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int AverageWaitSeconds
        {
            get => _averageWaitSeconds;
            set
            {
                AverageWaitSecondsSpecified = true;
                _averageWaitSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageWaitSecondsSpecified { get; set; }

        protected int _averageAbandonmentSeconds;

        [XmlElement(ElementName = "averageAbandonmentSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7353")]
        public int AverageAbandonmentSeconds
        {
            get => _averageAbandonmentSeconds;
            set
            {
                AverageAbandonmentSecondsSpecified = true;
                _averageAbandonmentSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageAbandonmentSecondsSpecified { get; set; }

    }
}
