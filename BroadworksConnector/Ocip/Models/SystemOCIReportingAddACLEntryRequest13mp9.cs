using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingAddACLEntryRequest13mp9 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "restrictMessages", IsNullable = false)]
    public bool RestrictMessages { get; set; }
 }
}
