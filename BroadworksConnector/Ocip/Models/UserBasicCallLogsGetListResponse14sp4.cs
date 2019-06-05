using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBasicCallLogsGetListResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CallLogsEntry> _placed;

    [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Placed {
        get => _placed;
        set {
            PlacedSpecified = true;
            _placed = value;
        }
    }

    [XmlIgnore]
    public bool PlacedSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallLogsEntry> _received;

    [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Received {
        get => _received;
        set {
            ReceivedSpecified = true;
            _received = value;
        }
    }

    [XmlIgnore]
    public bool ReceivedSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallLogsEntry> _missed;

    [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Missed {
        get => _missed;
        set {
            MissedSpecified = true;
            _missed = value;
        }
    }

    [XmlIgnore]
    public bool MissedSpecified { get; set; }
}
}
