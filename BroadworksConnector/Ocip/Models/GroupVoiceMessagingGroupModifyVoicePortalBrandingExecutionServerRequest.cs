using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource VoicePortalGreetingFile { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource VoiceMessagingGreetingFile { get; set; }
 }
}
