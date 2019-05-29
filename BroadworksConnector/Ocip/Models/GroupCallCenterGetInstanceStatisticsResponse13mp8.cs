using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceStatisticsResponse13mp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false)]
    public int NumberOfCallsQueuedNow { get; set; }
    [XmlElement(ElementName = "generateDailyReport", IsNullable = false)]
    public bool GenerateDailyReport { get; set; }
    [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes { get; set; }
    [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = false)]
    public string ReportingEmailAddress1 { get; set; }
    [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = false)]
    public string ReportingEmailAddress2 { get; set; }
    [XmlElement(ElementName = "queueStatisticsYesterday", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsYesterday { get; set; }
    [XmlElement(ElementName = "queueStatisticsToday", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsToday { get; set; }
    [XmlElement(ElementName = "agentStatistics", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterAgentStatistics13mp8> AgentStatistics { get; set; }
 }
}
