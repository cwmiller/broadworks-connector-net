using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceSpeedDial8Info 
{
    [XmlElement(ElementName = "speedDialEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry { get; set; }
 }
}
