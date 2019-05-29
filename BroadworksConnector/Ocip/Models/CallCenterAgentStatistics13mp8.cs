using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentStatistics13mp8 
{
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public string AgentUserId { get; set; }
    [XmlElement(ElementName = "agentDisplayNames", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames { get; set; }
    [XmlElement(ElementName = "available", IsNullable = false)]
    public bool Available { get; set; }
    [XmlElement(ElementName = "statisticsYesterday", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsYesterday { get; set; }
    [XmlElement(ElementName = "statisticsToday", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsToday { get; set; }
 }
}
