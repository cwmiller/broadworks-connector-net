using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum BroadWorksAnywhereCLIDPrompt{
    [XmlEnum(Name = "Always Prompt")]
    AlwaysPrompt,
    [XmlEnum(Name = "Never Prompt")]
    NeverPrompt,
    [XmlEnum(Name = "Prompt When Not Available")]
    PromptWhenNotAvailable,
 }
}
