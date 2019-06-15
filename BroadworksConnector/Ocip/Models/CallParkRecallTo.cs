using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Park recall user options
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallParkRecallTo    {
            [XmlEnum(Name = "Parking User Only")]
        ParkingUserOnly,
            [XmlEnum(Name = "Parking User Then Alternate User")]
        ParkingUserThenAlternateUser,
            [XmlEnum(Name = "Alternate User Only")]
        AlternateUserOnly,
     }
}
