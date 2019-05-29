using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial8GetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "speedDialEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry { get; set; }
 }
}
