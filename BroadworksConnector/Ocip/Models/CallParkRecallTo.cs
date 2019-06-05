using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallParkRecallTo
    {
        [XmlEnum(Name = "Parking User Only")]
        ParkingUserOnly,
        [XmlEnum(Name = "Parking User Then Alternate User")]
        ParkingUserThenAlternateUser,
        [XmlEnum(Name = "Alternate User Only")]
        AlternateUserOnly,
    }
}
