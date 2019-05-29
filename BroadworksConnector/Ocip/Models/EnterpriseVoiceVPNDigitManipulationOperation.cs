using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnterpriseVoiceVPNDigitManipulationOperation{
    Prepend,
    End,
    Overwrite,
    RightTrim,
    ReplaceAll,
    LeftTrim,
    Append,
    Position,
    Insert,
    Trim,
    Delete,
    Move,
 }
}
