using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial100GetListResponse17sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "prefix", IsNullable = false)]
    public string Prefix { get; set; }
    [XmlElement(ElementName = "speedDialEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry { get; set; }
 }
}
