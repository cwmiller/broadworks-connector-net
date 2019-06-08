using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMaliciousCallTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useSystemPlayMCTWarningAnnouncement;

    [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
    public bool UseSystemPlayMCTWarningAnnouncement {
        get => _useSystemPlayMCTWarningAnnouncement;
        set {
            UseSystemPlayMCTWarningAnnouncementSpecified = true;
            _useSystemPlayMCTWarningAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemPlayMCTWarningAnnouncementSpecified { get; set; }
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
