using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum BroadWorksAnywhereCLIDPrompt{
    AlwaysPrompt,
    NeverPrompt,
    PromptWhenNotAvailable,
 }
}
