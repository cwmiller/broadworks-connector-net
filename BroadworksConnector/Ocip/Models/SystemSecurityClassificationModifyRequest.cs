using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _securityClassificationName;

    [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
    public List<string> SecurityClassificationName {
        get => _securityClassificationName;
        set {
            SecurityClassificationNameSpecified = true;
            _securityClassificationName = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationNameSpecified { get; set; }
}
}
