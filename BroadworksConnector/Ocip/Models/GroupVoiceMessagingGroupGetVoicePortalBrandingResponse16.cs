using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _voicePortalGreetingFileDescription;

    [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false, Namespace = "")]
    public string VoicePortalGreetingFileDescription {
        get => _voicePortalGreetingFileDescription;
        set {
            VoicePortalGreetingFileDescriptionSpecified = true;
            _voicePortalGreetingFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingFileDescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaFileType _voicePortalGreetingMediaType;

    [XmlElement(ElementName = "voicePortalGreetingMediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaType {
        get => _voicePortalGreetingMediaType;
        set {
            VoicePortalGreetingMediaTypeSpecified = true;
            _voicePortalGreetingMediaType = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingMediaTypeSpecified { get; set; }
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
    private string _voiceMessagingGreetingFileDescription;

    [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false, Namespace = "")]
    public string VoiceMessagingGreetingFileDescription {
        get => _voiceMessagingGreetingFileDescription;
        set {
            VoiceMessagingGreetingFileDescriptionSpecified = true;
            _voiceMessagingGreetingFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingFileDescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaFileType _voiceMessagingGreetingMediaType;

    [XmlElement(ElementName = "voiceMessagingGreetingMediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaType {
        get => _voiceMessagingGreetingMediaType;
        set {
            VoiceMessagingGreetingMediaTypeSpecified = true;
            _voiceMessagingGreetingMediaType = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingMediaTypeSpecified { get; set; }
}
}
