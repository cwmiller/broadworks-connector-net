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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7301""}]")]
    public class AgentStatistics
    {

        protected int _numberOfCallsHandled;

        [XmlElement(ElementName = "numberOfCallsHandled", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7301")]
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

        protected int _numberOfCallsUnanswered;

        [XmlElement(ElementName = "numberOfCallsUnanswered", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7301")]
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

        protected int _averageCallSeconds;

        [XmlElement(ElementName = "averageCallSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7301")]
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

        protected int _totalTalkSeconds;

        [XmlElement(ElementName = "totalTalkSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7301")]
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

        protected int _totalStaffedSeconds;

        [XmlElement(ElementName = "totalStaffedSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7301")]
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
