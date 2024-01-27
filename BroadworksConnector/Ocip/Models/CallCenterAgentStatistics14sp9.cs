using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics for a specified agent.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7316""}]")]
    public class CallCenterAgentStatistics14sp9
    {

        protected string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7316")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserDisplayNames _agentDisplayNames;

        [XmlElement(ElementName = "agentDisplayNames", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7316")]
        public BroadWorksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames
        {
            get => _agentDisplayNames;
            set
            {
                AgentDisplayNamesSpecified = true;
                _agentDisplayNames = value;
            }
        }

        [XmlIgnore]
        protected bool AgentDisplayNamesSpecified { get; set; }

        protected bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7316")]
        public bool Available
        {
            get => _available;
            set
            {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AgentStatistics _statistics;

        [XmlElement(ElementName = "statistics", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7316")]
        public BroadWorksConnector.Ocip.Models.AgentStatistics Statistics
        {
            get => _statistics;
            set
            {
                StatisticsSpecified = true;
                _statistics = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsSpecified { get; set; }

    }
}
