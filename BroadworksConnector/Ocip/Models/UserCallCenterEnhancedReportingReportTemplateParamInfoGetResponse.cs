using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isRealtimeReport", IsNullable = false)]
    public bool IsRealtimeReport { get; set; }
    [XmlElement(ElementName = "requireAgentParam", IsNullable = false)]
    public bool RequireAgentParam { get; set; }
    [XmlElement(ElementName = "requireCallCenterParam", IsNullable = false)]
    public bool RequireCallCenterParam { get; set; }
    [XmlElement(ElementName = "requireCallCenterDnisParam", IsNullable = false)]
    public bool RequireCallCenterDnisParam { get; set; }
    [XmlElement(ElementName = "requireSamplingPeriodParam", IsNullable = false)]
    public bool RequireSamplingPeriodParam { get; set; }
    [XmlElement(ElementName = "callCompletionThresholdParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption CallCompletionThresholdParam { get; set; }
    [XmlElement(ElementName = "shortDurationThresholdParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ShortDurationThresholdParam { get; set; }
    [XmlElement(ElementName = "serviceLevelThresholdParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelThresholdParam { get; set; }
    [XmlElement(ElementName = "serviceLevelInclusionsParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelInclusionsParam { get; set; }
    [XmlElement(ElementName = "serviceLevelObjectiveThresholdParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelObjectiveThresholdParam { get; set; }
    [XmlElement(ElementName = "abandonedCallThresholdParam", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption AbandonedCallThresholdParam { get; set; }
    [XmlElement(ElementName = "serviceLevelThresholdParamNumber", IsNullable = false)]
    public int ServiceLevelThresholdParamNumber { get; set; }
    [XmlElement(ElementName = "abandonedCallThresholdParamNumber", IsNullable = false)]
    public int AbandonedCallThresholdParamNumber { get; set; }
 }
}
