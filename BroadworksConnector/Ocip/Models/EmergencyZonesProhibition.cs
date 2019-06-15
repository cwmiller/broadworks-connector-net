using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Emergency zone policy to specify what kind of calls will be prohibited by the service when
    /// originated from outside the home zone.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EmergencyZonesProhibition    {
            [XmlEnum(Name = "Prohibit all registrations and call originations")]
        Prohibitallregistrationsandcalloriginations,
            [XmlEnum(Name = "Prohibit emergency call originations")]
        Prohibitemergencycalloriginations,
     }
}
