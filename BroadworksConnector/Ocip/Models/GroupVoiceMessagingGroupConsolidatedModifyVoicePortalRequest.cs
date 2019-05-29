using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers { get; set; }
    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false)]
    public bool AddPhoneNumberToGroup { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "enableExtendedScope", IsNullable = false)]
    public bool EnableExtendedScope { get; set; }
    [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false)]
    public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin { get; set; }
    [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false)]
    public bool UseVoicePortalWizard { get; set; }
    [XmlElement(ElementName = "voicePortalExternalRoutingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoicePortalExternalRoutingScope VoicePortalExternalRoutingScope { get; set; }
    [XmlElement(ElementName = "useExternalRouting", IsNullable = false)]
    public bool UseExternalRouting { get; set; }
    [XmlElement(ElementName = "externalRoutingAddress", IsNullable = true)]
    public string ExternalRoutingAddress { get; set; }
    [XmlElement(ElementName = "homeZoneName", IsNullable = true)]
    public string HomeZoneName { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VoicePortalGreetingFile { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VoiceMessagingGreetingFile { get; set; }
 }
}
