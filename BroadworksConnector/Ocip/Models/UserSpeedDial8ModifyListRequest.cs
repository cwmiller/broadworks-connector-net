using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial8ModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "speedDialEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry { get; set; }
 }
}
