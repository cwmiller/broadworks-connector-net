using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "officeZoneName", IsNullable = false)]
    public string OfficeZoneName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public List<string> ZoneName { get; set; }
    [XmlElement(ElementName = "primaryZoneName", IsNullable = false)]
    public string PrimaryZoneName { get; set; }
 }
}
