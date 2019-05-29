using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportTemplateKey 
{
    [XmlElement(ElementName = "templateLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateLevel TemplateLevel { get; set; }
    [XmlElement(ElementName = "templateName", IsNullable = false)]
    public string TemplateName { get; set; }
 }
}
