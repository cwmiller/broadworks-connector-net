using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center Agent statistics for one day.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47624""}]")]
    public class CallCenterAgentDailyStatistics13mp8
    {

        protected int _numberOfCallsReceived;

        [XmlElement(ElementName = "numberOfCallsReceived", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int NumberOfCallsReceived
        {
            get => _numberOfCallsReceived;
            set
            {
                NumberOfCallsReceivedSpecified = true;
                _numberOfCallsReceived = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsReceivedSpecified { get; set; }

        protected int _numberOfCallsNotAnswered;

        [XmlElement(ElementName = "numberOfCallsNotAnswered", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int NumberOfCallsNotAnswered
        {
            get => _numberOfCallsNotAnswered;
            set
            {
                NumberOfCallsNotAnsweredSpecified = true;
                _numberOfCallsNotAnswered = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsNotAnsweredSpecified { get; set; }

        protected int _averageTimePerCallSeconds;

        [XmlElement(ElementName = "averageTimePerCallSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int AverageTimePerCallSeconds
        {
            get => _averageTimePerCallSeconds;
            set
            {
                AverageTimePerCallSecondsSpecified = true;
                _averageTimePerCallSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageTimePerCallSecondsSpecified { get; set; }

        protected int _timeInCallsSeconds;

        [XmlElement(ElementName = "timeInCallsSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int TimeInCallsSeconds
        {
            get => _timeInCallsSeconds;
            set
            {
                TimeInCallsSecondsSpecified = true;
                _timeInCallsSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInCallsSecondsSpecified { get; set; }

        protected int _timeLoggedOffSeconds;

        [XmlElement(ElementName = "timeLoggedOffSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int TimeLoggedOffSeconds
        {
            get => _timeLoggedOffSeconds;
            set
            {
                TimeLoggedOffSecondsSpecified = true;
                _timeLoggedOffSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeLoggedOffSecondsSpecified { get; set; }

        protected int _timeLoggedOnAndIdleSeconds;

        [XmlElement(ElementName = "timeLoggedOnAndIdleSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47624")]
        public int TimeLoggedOnAndIdleSeconds
        {
            get => _timeLoggedOnAndIdleSeconds;
            set
            {
                TimeLoggedOnAndIdleSecondsSpecified = true;
                _timeLoggedOnAndIdleSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeLoggedOnAndIdleSecondsSpecified { get; set; }

    }
}
