using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "officeZoneName", IsNullable = false)]
    public string OfficeZoneName { get; set; }
    [XmlElement(ElementName = "newOfficeZoneName", IsNullable = false)]
    public string NewOfficeZoneName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "replacementZoneList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ReplacementZoneList ReplacementZoneList { get; set; }
    [XmlElement(ElementName = "primaryZoneName", IsNullable = false)]
    public string PrimaryZoneName { get; set; }
 }
}
