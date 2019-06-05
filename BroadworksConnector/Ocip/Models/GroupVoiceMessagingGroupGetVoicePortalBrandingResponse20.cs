using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection {
        get => _voicePortalGreetingSelection;
        set {
            VoicePortalGreetingSelectionSpecified = true;
            _voicePortalGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _voicePortalGreetingFile;

    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VoicePortalGreetingFile {
        get => _voicePortalGreetingFile;
        set {
            VoicePortalGreetingFileSpecified = true;
            _voicePortalGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection {
        get => _voiceMessagingGreetingSelection;
        set {
            VoiceMessagingGreetingSelectionSpecified = true;
            _voiceMessagingGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _voiceMessagingGreetingFile;

    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VoiceMessagingGreetingFile {
        get => _voiceMessagingGreetingFile;
        set {
            VoiceMessagingGreetingFileSpecified = true;
            _voiceMessagingGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingFileSpecified { get; set; }
}
}
