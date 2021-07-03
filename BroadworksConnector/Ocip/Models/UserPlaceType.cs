using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Search for user type - 'user' or 'place'. If user type is not
    /// included, the search looks for ‘both’.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UserPlaceType
    {
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Place")]
        Place,
    }
}
