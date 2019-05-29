using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnterpriseVoiceVPNDigitManipulationOperationOptionalValue{
    Prepend,
    Overwrite,
    RightTrim,
    ReplaceAll,
    LeftTrim,
    Append,
    Insert,
    Trim,
 }
}
