using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AdviceOfChargeType{
    [XmlEnum(Name = "During Call")]
    DuringCall,
    [XmlEnum(Name = "End Of Call")]
    EndOfCall,
 }
}
