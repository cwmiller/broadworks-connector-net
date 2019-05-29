using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingDeleteMessageNameListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "deleteAllMessageNames", IsNullable = false)]
    public bool DeleteAllMessageNames { get; set; }
    [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false)]
    public List<string> MessageNameStartsWith { get; set; }
 }
}
