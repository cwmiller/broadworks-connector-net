using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _recallTimerSeconds;

    [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
    public int RecallTimerSeconds {
        get => _recallTimerSeconds;
        set {
            RecallTimerSecondsSpecified = true;
            _recallTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RecallTimerSecondsSpecified { get; set; }
    private int _displayTimerSeconds;

    [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
    public int DisplayTimerSeconds {
        get => _displayTimerSeconds;
        set {
            DisplayTimerSecondsSpecified = true;
            _displayTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DisplayTimerSecondsSpecified { get; set; }
    private bool _enableDestinationAnnouncement;

    [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
    public bool EnableDestinationAnnouncement {
        get => _enableDestinationAnnouncement;
        set {
            EnableDestinationAnnouncementSpecified = true;
            _enableDestinationAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool EnableDestinationAnnouncementSpecified { get; set; }
}
}
