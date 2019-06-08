using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CPEDeviceResetEventType{
    [XmlEnum(Name = "Resync")]
    Resync,
    [XmlEnum(Name = "Check Sync")]
    CheckSync,
 }
}
