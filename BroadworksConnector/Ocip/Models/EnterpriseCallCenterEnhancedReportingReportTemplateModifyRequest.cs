using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "xsltTemplate", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource XsltTemplate { get; set; }
    [XmlElement(ElementName = "scope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateAccessOption Scope { get; set; }
    [XmlElement(ElementName = "isEnabled", IsNullable = false)]
    public bool IsEnabled { get; set; }
    [XmlElement(ElementName = "isRealtimeReport", IsNullable = false)]
    public bool IsRealtimeReport { get; set; }
    [XmlElement(ElementName = "filterNumber", IsNullable = true)]
    public int? FilterNumber { get; set; }
    [XmlElement(ElementName = "filterValue", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateQueryFilterValueReplacementList FilterValue { get; set; }
 }
}
