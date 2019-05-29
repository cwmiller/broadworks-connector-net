using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportDataTemplateQueryFilterValueReplacementList 
{
    [XmlElement(ElementName = "filterValue", IsNullable = false)]
    public List<string> FilterValue { get; set; }
 }
}
