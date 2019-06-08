using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBasicCallLogsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _placed;

    [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Placed {
        get => _placed;
        set {
            PlacedSpecified = true;
            _placed = value;
        }
    }

    [XmlIgnore]
    public bool PlacedSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _received;

    [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Received {
        get => _received;
        set {
            ReceivedSpecified = true;
            _received = value;
        }
    }

    [XmlIgnore]
    public bool ReceivedSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _missed;

    [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Missed {
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
