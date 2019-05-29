using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public List<string> ZoneName { get; set; }
    [XmlElement(ElementName = "primaryZoneName", IsNullable = false)]
    public string PrimaryZoneName { get; set; }
 }
}
