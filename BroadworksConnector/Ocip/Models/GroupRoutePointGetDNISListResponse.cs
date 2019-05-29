using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "displayDNISNumber", IsNullable = false)]
    public bool DisplayDNISNumber { get; set; }
    [XmlElement(ElementName = "displayDNISName", IsNullable = false)]
    public bool DisplayDNISName { get; set; }
    [XmlElement(ElementName = "dnisTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DnisTable { get; set; }
 }
}
