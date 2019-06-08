using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SliceType{
    [XmlEnum(Name = "Call Processing")]
    CallProcessing,
    [XmlEnum(Name = "Provisioning")]
    Provisioning,
 }
}
