using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceSpeedDial8Info 
{
    private List<BroadworksConnector.Ocip.Models.SpeedDial8Entry> _speedDialEntry;

    [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry {
        get => _speedDialEntry;
        set {
            SpeedDialEntrySpecified = true;
            _speedDialEntry = value;
        }
    }

    [XmlIgnore]
    public bool SpeedDialEntrySpecified { get; set; }
}
}
