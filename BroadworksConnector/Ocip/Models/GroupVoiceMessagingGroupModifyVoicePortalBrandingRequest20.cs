using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection {
        get => _voicePortalGreetingSelection;
        set {
            VoicePortalGreetingSelectionSpecified = true;
            _voicePortalGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _voicePortalGreetingFile;

    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VoicePortalGreetingFile {
        get => _voicePortalGreetingFile;
        set {
            VoicePortalGreetingFileSpecified = true;
            _voicePortalGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection {
        get => _voiceMessagingGreetingSelection;
        set {
            VoiceMessagingGreetingSelectionSpecified = true;
            _voiceMessagingGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _voiceMessagingGreetingFile;

    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VoiceMessagingGreetingFile {
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
