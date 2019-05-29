using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingReportTemplateAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "dataTemplate", IsNullable = false)]
    public string DataTemplate { get; set; }
    [XmlElement(ElementName = "filterNumber", IsNullable = false)]
    public int FilterNumber { get; set; }
    [XmlElement(ElementName = "xsltTemplate", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource XsltTemplate { get; set; }
    [XmlElement(ElementName = "scope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateAccessOption Scope { get; set; }
    [XmlElement(ElementName = "isEnabled", IsNullable = false)]
    public bool IsEnabled { get; set; }
    [XmlElement(ElementName = "isRealtimeReport", IsNullable = false)]
    public bool IsRealtimeReport { get; set; }
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
    [XmlElement(ElementName = "filterValue", IsNullable = false)]
    public List<string> FilterValue { get; set; }
 }
}
