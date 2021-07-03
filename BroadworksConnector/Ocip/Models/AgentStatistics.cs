using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center Agent statistics for a given time frame.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7315""}]")]
    public class AgentStatistics
    {

        private int _numberOfCallsHandled;

        [XmlElement(ElementName = "numberOfCallsHandled", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7315")]
        public int NumberOfCallsHandled
        {
            get => _numberOfCallsHandled;
            set
            {
                NumberOfCallsHandledSpecified = true;
                _numberOfCallsHandled = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsHandledSpecified { get; set; }

        private int _numberOfCallsUnanswered;

        [XmlElement(ElementName = "numberOfCallsUnanswered", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7315")]
        public int NumberOfCallsUnanswered
        {
            get => _numberOfCallsUnanswered;
            set
            {
                NumberOfCallsUnansweredSpecified = true;
                _numberOfCallsUnanswered = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsUnansweredSpecified { get; set; }

        private int _averageCallSeconds;

        [XmlElement(ElementName = "averageCallSeconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7315")]
        public int AverageCallSeconds
        {
            get => _averageCallSeconds;
            set
            {
                AverageCallSecondsSpecified = true;
                _averageCallSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AverageCallSecondsSpecified { get; set; }

        private int _totalTalkSeconds;

        [XmlElement(ElementName = "totalTalkSeconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7315")]
        public int TotalTalkSeconds
        {
            get => _totalTalkSeconds;
            set
            {
                TotalTalkSecondsSpecified = true;
                _totalTalkSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TotalTalkSecondsSpecified { get; set; }

        private int _totalStaffedSeconds;

        [XmlElement(ElementName = "totalStaffedSeconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7315")]
        public int TotalStaffedSeconds
        {
            get => _totalStaffedSeconds;
            set
            {
                TotalStaffedSecondsSpecified = true;
                _totalStaffedSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TotalStaffedSecondsSpecified { get; set; }

    }
}
