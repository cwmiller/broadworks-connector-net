using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportDataTemplateInfo 
{
    [XmlElement(ElementName = "dataTemplate", IsNullable = false)]
    public string DataTemplate { get; set; }
    [XmlElement(ElementName = "reportType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportType ReportType { get; set; }
    [XmlElement(ElementName = "isRealtimeReport", IsNullable = false)]
    public bool IsRealtimeReport { get; set; }
    [XmlElement(ElementName = "isAgentParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAgentParamRequired { get; set; }
    [XmlElement(ElementName = "isCallCenterParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterParamRequired { get; set; }
    [XmlElement(ElementName = "isCallCenterDnisParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterDnisParamRequired { get; set; }
    [XmlElement(ElementName = "isSamplingPeriodParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsSamplingPeriodParamRequired { get; set; }
    [XmlElement(ElementName = "isCallCompletionThresholdParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCompletionThresholdParamRequired { get; set; }
    [XmlElement(ElementName = "isShortDurationThresholdParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsShortDurationThresholdParamRequired { get; set; }
    [XmlElement(ElementName = "isServiceLevelThresholdParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelThresholdParamRequired { get; set; }
    [XmlElement(ElementName = "isServiceLevelInclusionsParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelInclusionsParamRequired { get; set; }
    [XmlElement(ElementName = "isServiceLevelObjectiveThresholdParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelObjectiveThresholdParamRequired { get; set; }
    [XmlElement(ElementName = "isAbandonedCallThresholdParamRequired", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAbandonedCallThresholdParamRequired { get; set; }
 }
}
