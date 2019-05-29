using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceStatisticsResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "statisticsRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange { get; set; }
    [XmlElement(ElementName = "queueStatistics", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterQueueStatistics14sp9 QueueStatistics { get; set; }
    [XmlElement(ElementName = "agentStatistics", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterAgentStatistics14sp9> AgentStatistics { get; set; }
 }
}
