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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48659""}]")]
    public class CallCenterQueueStatistics13mp8
    {

        protected int _numberOfIncomingCalls;

        [XmlElement(ElementName = "numberOfIncomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public int NumberOfIncomingCalls
        {
            get => _numberOfIncomingCalls;
            set
            {
                NumberOfIncomingCallsSpecified = true;
                _numberOfIncomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfIncomingCallsSpecified { get; set; }

        protected int _numberOfCallsQueued;

        [XmlElement(ElementName = "numberOfCallsQueued", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public int NumberOfCallsQueued
        {
            get => _numberOfCallsQueued;
            set
            {
                NumberOfCallsQueuedSpecified = true;
                _numberOfCallsQueued = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsQueuedSpecified { get; set; }

        protected int _numberOfBusyOverflows;

        [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
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

        protected int _averageTimeWithAgentSeconds;

        [XmlElement(ElementName = "averageTimeWithAgentSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public int AverageTimeWithAgentSeconds
        {
            get => _averageTimeWithAgentSeconds;
            set
            {
                AverageTimeWithAgentSecondsSpecified = true;
                _averageTimeWithAgentSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageTimeWithAgentSecondsSpecified { get; set; }

        protected int _averageTimeInQueueSeconds;

        [XmlElement(ElementName = "averageTimeInQueueSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public int AverageTimeInQueueSeconds
        {
            get => _averageTimeInQueueSeconds;
            set
            {
                AverageTimeInQueueSecondsSpecified = true;
                _averageTimeInQueueSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageTimeInQueueSecondsSpecified { get; set; }

        protected string _averageNumberOfAgentsBusy;

        [XmlElement(ElementName = "averageNumberOfAgentsBusy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public string AverageNumberOfAgentsBusy
        {
            get => _averageNumberOfAgentsBusy;
            set
            {
                AverageNumberOfAgentsBusySpecified = true;
                _averageNumberOfAgentsBusy = value;
            }
        }

        [XmlIgnore]
        protected bool AverageNumberOfAgentsBusySpecified { get; set; }

        protected string _averageNumberOfAgentsLoggedOff;

        [XmlElement(ElementName = "averageNumberOfAgentsLoggedOff", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public string AverageNumberOfAgentsLoggedOff
        {
            get => _averageNumberOfAgentsLoggedOff;
            set
            {
                AverageNumberOfAgentsLoggedOffSpecified = true;
                _averageNumberOfAgentsLoggedOff = value;
            }
        }

        [XmlIgnore]
        protected bool AverageNumberOfAgentsLoggedOffSpecified { get; set; }

        protected int _averageHoldTimeBeforeCallLossSeconds;

        [XmlElement(ElementName = "averageHoldTimeBeforeCallLossSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48659")]
        public int AverageHoldTimeBeforeCallLossSeconds
        {
            get => _averageHoldTimeBeforeCallLossSeconds;
            set
            {
                AverageHoldTimeBeforeCallLossSecondsSpecified = true;
                _averageHoldTimeBeforeCallLossSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageHoldTimeBeforeCallLossSecondsSpecified { get; set; }

    }
}
