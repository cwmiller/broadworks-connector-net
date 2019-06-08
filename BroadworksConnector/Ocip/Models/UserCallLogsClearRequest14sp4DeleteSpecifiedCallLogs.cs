using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs 
{
    private List<string> _placedCallLogId;

    [XmlElement(ElementName = "placedCallLogId", IsNullable = false, Namespace = "")]
    public List<string> PlacedCallLogId {
        get => _placedCallLogId;
        set {
            PlacedCallLogIdSpecified = true;
            _placedCallLogId = value;
        }
    }

    [XmlIgnore]
    public bool PlacedCallLogIdSpecified { get; set; }
    private List<string> _receivedCallLogId;

    [XmlElement(ElementName = "receivedCallLogId", IsNullable = false, Namespace = "")]
    public List<string> ReceivedCallLogId {
        get => _receivedCallLogId;
        set {
            ReceivedCallLogIdSpecified = true;
            _receivedCallLogId = value;
        }
    }

    [XmlIgnore]
    public bool ReceivedCallLogIdSpecified { get; set; }
    private List<string> _missedCallLogId;

    [XmlElement(ElementName = "missedCallLogId", IsNullable = false, Namespace = "")]
    public List<string> MissedCallLogId {
        get => _missedCallLogId;
        set {
            MissedCallLogIdSpecified = true;
            _missedCallLogId = value;
        }
    }

    [XmlIgnore]
    public bool MissedCallLogIdSpecified { get; set; }
}
}
