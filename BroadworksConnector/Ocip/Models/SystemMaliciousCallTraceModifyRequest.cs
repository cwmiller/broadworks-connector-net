using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _playMCTWarningAnnouncement;

    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
    public bool PlayMCTWarningAnnouncement {
        get => _playMCTWarningAnnouncement;
        set {
            PlayMCTWarningAnnouncementSpecified = true;
            _playMCTWarningAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool PlayMCTWarningAnnouncementSpecified { get; set; }
}
}
