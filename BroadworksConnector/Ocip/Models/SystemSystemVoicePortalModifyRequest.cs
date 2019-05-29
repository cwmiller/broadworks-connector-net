using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false)]
    public string SystemVoicePortalId { get; set; }
    [XmlElement(ElementName = "newSystemVoicePortalId", IsNullable = false)]
    public string NewSystemVoicePortalId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = true)]
    public string PublicUserIdentity { get; set; }
    [XmlElement(ElementName = "networkVoicePortalNumber", IsNullable = true)]
    public string NetworkVoicePortalNumber { get; set; }
    [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false)]
    public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin { get; set; }
    [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false)]
    public bool UseVoicePortalWizard { get; set; }
    [XmlElement(ElementName = "becomeDefaultSystemVoicePortal", IsNullable = false)]
    public bool BecomeDefaultSystemVoicePortal { get; set; }
    [XmlElement(ElementName = "useVoicePortalDefaultGreeting", IsNullable = false)]
    public bool UseVoicePortalDefaultGreeting { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VoicePortalGreetingFile { get; set; }
    [XmlElement(ElementName = "useVoiceMessagingDefaultGreeting", IsNullable = false)]
    public bool UseVoiceMessagingDefaultGreeting { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VoiceMessagingGreetingFile { get; set; }
    [XmlElement(ElementName = "expressMode", IsNullable = false)]
    public bool ExpressMode { get; set; }
 }
}
