using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupGetVoicePortalResponse17sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
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
    [XmlElement(ElementName = "externalRoutingAddress", IsNullable = false)]
    public string ExternalRoutingAddress { get; set; }
    [XmlElement(ElementName = "homeZoneName", IsNullable = false)]
    public string HomeZoneName { get; set; }
 }
}
