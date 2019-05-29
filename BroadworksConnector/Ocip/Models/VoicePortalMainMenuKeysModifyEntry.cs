using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoicePortalMainMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "voiceMessaging", IsNullable = true)]
    public string VoiceMessaging { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = true)]
    public string CommPilotExpressProfile { get; set; }
    [XmlElement(ElementName = "greetings", IsNullable = true)]
    public string Greetings { get; set; }
    [XmlElement(ElementName = "callForwardingOptions", IsNullable = true)]
    public string CallForwardingOptions { get; set; }
    [XmlElement(ElementName = "voicePortalCalling", IsNullable = true)]
    public string VoicePortalCalling { get; set; }
    [XmlElement(ElementName = "hoteling", IsNullable = true)]
    public string Hoteling { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = true)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "exitVoicePortal", IsNullable = true)]
    public string ExitVoicePortal { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
    [XmlElement(ElementName = "externalRouting", IsNullable = true)]
    public string ExternalRouting { get; set; }
    [XmlElement(ElementName = "announcement", IsNullable = true)]
    public string Announcement { get; set; }
    [XmlElement(ElementName = "personalAssistant", IsNullable = true)]
    public string PersonalAssistant { get; set; }
 }
}
