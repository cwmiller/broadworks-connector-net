using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _meetMeAnncThreshold;

    [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
    public int MeetMeAnncThreshold {
        get => _meetMeAnncThreshold;
        set {
            MeetMeAnncThresholdSpecified = true;
            _meetMeAnncThreshold = value;
        }
    }

    [XmlIgnore]
    public bool MeetMeAnncThresholdSpecified { get; set; }
    private bool _playTrunkUserSecurityClassificationAnnouncement;

    [XmlElement(ElementName = "playTrunkUserSecurityClassificationAnnouncement", IsNullable = false, Namespace = "")]
    public bool PlayTrunkUserSecurityClassificationAnnouncement {
        get => _playTrunkUserSecurityClassificationAnnouncement;
        set {
            PlayTrunkUserSecurityClassificationAnnouncementSpecified = true;
            _playTrunkUserSecurityClassificationAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool PlayTrunkUserSecurityClassificationAnnouncementSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _securityClassificationTable;

    [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SecurityClassificationTable {
        get => _securityClassificationTable;
        set {
            SecurityClassificationTableSpecified = true;
            _securityClassificationTable = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationTableSpecified { get; set; }
}
}
