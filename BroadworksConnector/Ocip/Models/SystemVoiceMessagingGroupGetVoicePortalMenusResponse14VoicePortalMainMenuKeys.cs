using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoicePortalMainMenuKeys 
{
    [XmlElement(ElementName = "voiceMessaging", IsNullable = false)]
    public string VoiceMessaging { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = false)]
    public string CommPilotExpressProfile { get; set; }
    [XmlElement(ElementName = "personalizedName", IsNullable = false)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "callForwardingOptions", IsNullable = false)]
    public string CallForwardingOptions { get; set; }
    [XmlElement(ElementName = "voicePortalCalling", IsNullable = false)]
    public string VoicePortalCalling { get; set; }
    [XmlElement(ElementName = "hoteling", IsNullable = false)]
    public string Hoteling { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = false)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "exitVoicePortal", IsNullable = false)]
    public string ExitVoicePortal { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
    [XmlElement(ElementName = "externalRouting", IsNullable = false)]
    public string ExternalRouting { get; set; }
 }
}
