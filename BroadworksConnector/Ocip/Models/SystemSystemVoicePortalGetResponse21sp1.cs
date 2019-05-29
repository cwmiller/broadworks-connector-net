using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false)]
    public string PublicUserIdentity { get; set; }
    [XmlElement(ElementName = "networkVoicePortalNumber", IsNullable = false)]
    public string NetworkVoicePortalNumber { get; set; }
    [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false)]
    public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin { get; set; }
    [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false)]
    public bool UseVoicePortalWizard { get; set; }
    [XmlElement(ElementName = "isDefault", IsNullable = false)]
    public bool IsDefault { get; set; }
    [XmlElement(ElementName = "useVoicePortalDefaultGreeting", IsNullable = false)]
    public bool UseVoicePortalDefaultGreeting { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false)]
    public string VoicePortalGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingMediaFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaFileType { get; set; }
    [XmlElement(ElementName = "useVoiceMessagingDefaultGreeting", IsNullable = false)]
    public bool UseVoiceMessagingDefaultGreeting { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false)]
    public string VoiceMessagingGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingMediaFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaFileType { get; set; }
    [XmlElement(ElementName = "expressMode", IsNullable = false)]
    public bool ExpressMode { get; set; }
 }
}
