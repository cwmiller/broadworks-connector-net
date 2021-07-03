using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The login role associated with the user id
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LoginRole
    {
        [XmlEnum(Name = "Administrator")]
        Administrator,
        [XmlEnum(Name = "User")]
        User,
    }
}
