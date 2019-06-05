using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallNotificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enablePostAnnouncementDelayTimer;

    [XmlElement(ElementName = "enablePostAnnouncementDelayTimer", IsNullable = false, Namespace = "")]
    public bool EnablePostAnnouncementDelayTimer {
        get => _enablePostAnnouncementDelayTimer;
        set {
            EnablePostAnnouncementDelayTimerSpecified = true;
            _enablePostAnnouncementDelayTimer = value;
        }
    }

    [XmlIgnore]
    public bool EnablePostAnnouncementDelayTimerSpecified { get; set; }
    private int _postAnnouncementDelaySeconds;

    [XmlElement(ElementName = "postAnnouncementDelaySeconds", IsNullable = false, Namespace = "")]
    public int PostAnnouncementDelaySeconds {
        get => _postAnnouncementDelaySeconds;
        set {
            PostAnnouncementDelaySecondsSpecified = true;
            _postAnnouncementDelaySeconds = value;
        }
    }

    [XmlIgnore]
    public bool PostAnnouncementDelaySecondsSpecified { get; set; }
}
}
