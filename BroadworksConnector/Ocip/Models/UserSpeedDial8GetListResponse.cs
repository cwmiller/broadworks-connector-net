using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial8GetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> _speedDialEntry;

    [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry {
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
