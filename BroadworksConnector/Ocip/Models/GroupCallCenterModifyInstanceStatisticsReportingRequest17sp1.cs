using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "generateDailyReport", IsNullable = false)]
    public bool GenerateDailyReport { get; set; }
    [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes { get; set; }
    [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = true)]
    public string ReportingEmailAddress1 { get; set; }
    [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = true)]
    public string ReportingEmailAddress2 { get; set; }
    [XmlElement(ElementName = "statisticsSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSource17sp1 StatisticsSource { get; set; }
 }
}
