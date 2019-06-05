using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial100GetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _prefix;

    [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
    public string Prefix {
        get => _prefix;
        set {
            PrefixSpecified = true;
            _prefix = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SpeedDial100Entry> _speedDialEntry;

    [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry {
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
