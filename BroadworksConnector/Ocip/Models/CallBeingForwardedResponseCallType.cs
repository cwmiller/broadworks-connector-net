using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallBeingForwardedResponseCallType{
    [XmlEnum(Name = "Never")]
    Never,
    [XmlEnum(Name = "Internal Calls")]
    InternalCalls,
    [XmlEnum(Name = "All Calls")]
    AllCalls,
 }
}
