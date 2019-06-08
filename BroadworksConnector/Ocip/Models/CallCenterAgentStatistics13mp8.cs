using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentStatistics13mp8 
{
    private string _agentUserId;

    [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
    public string AgentUserId {
        get => _agentUserId;
        set {
            AgentUserIdSpecified = true;
            _agentUserId = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UserDisplayNames _agentDisplayNames;

    [XmlElement(ElementName = "agentDisplayNames", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames {
        get => _agentDisplayNames;
        set {
            AgentDisplayNamesSpecified = true;
            _agentDisplayNames = value;
        }
    }

    [XmlIgnore]
    public bool AgentDisplayNamesSpecified { get; set; }
    private bool _available;

    [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
    public bool Available {
        get => _available;
        set {
            AvailableSpecified = true;
            _available = value;
        }
    }

    [XmlIgnore]
    public bool AvailableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 _statisticsYesterday;

    [XmlElement(ElementName = "statisticsYesterday", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsYesterday {
        get => _statisticsYesterday;
        set {
            StatisticsYesterdaySpecified = true;
            _statisticsYesterday = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsYesterdaySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 _statisticsToday;

    [XmlElement(ElementName = "statisticsToday", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsToday {
        get => _statisticsToday;
        set {
            StatisticsTodaySpecified = true;
            _statisticsToday = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsTodaySpecified { get; set; }
}
}
