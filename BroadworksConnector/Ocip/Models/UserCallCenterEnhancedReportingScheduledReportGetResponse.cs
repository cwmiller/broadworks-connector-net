using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterEnhancedReportingScheduledReportGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "reportTemplate", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate { get; set; }
    [XmlElement(ElementName = "schedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportSchedule Schedule { get; set; }
    [XmlElement(ElementName = "samplingPeriod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportSamplingPeriod SamplingPeriod { get; set; }
    [XmlElement(ElementName = "startDayOfWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DayOfWeek StartDayOfWeek { get; set; }
    [XmlElement(ElementName = "reportTimeZone", IsNullable = false)]
    public string ReportTimeZone { get; set; }
    [XmlElement(ElementName = "reportDateFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDateFormat ReportDateFormat { get; set; }
    [XmlElement(ElementName = "reportTimeFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTimeFormat ReportTimeFormat { get; set; }
    [XmlElement(ElementName = "reportInterval", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInterval ReportInterval { get; set; }
    [XmlElement(ElementName = "reportFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportFileFormat ReportFormat { get; set; }
    [XmlElement(ElementName = "agent", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledReportAgentSelectionRead Agent { get; set; }
    [XmlElement(ElementName = "callCenter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelection CallCenter { get; set; }
    [XmlElement(ElementName = "dnis", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledReportDNISSelection Dnis { get; set; }
    [XmlElement(ElementName = "callCompletionThresholdSeconds", IsNullable = false)]
    public int CallCompletionThresholdSeconds { get; set; }
    [XmlElement(ElementName = "shortDurationThresholdSeconds", IsNullable = false)]
    public int ShortDurationThresholdSeconds { get; set; }
    [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false)]
    public List<int> ServiceLevelThresholdSeconds { get; set; }
    [XmlElement(ElementName = "serviceLevelInclusions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions ServiceLevelInclusions { get; set; }
    [XmlElement(ElementName = "serviceLevelObjectivePercentage", IsNullable = false)]
    public int ServiceLevelObjectivePercentage { get; set; }
    [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false)]
    public List<int> AbandonedCallThresholdSeconds { get; set; }
    [XmlElement(ElementName = "emailAddress", IsNullable = false)]
    public List<string> EmailAddress { get; set; }
 }
}
