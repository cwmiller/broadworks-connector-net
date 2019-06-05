using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMaliciousCallTraceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
