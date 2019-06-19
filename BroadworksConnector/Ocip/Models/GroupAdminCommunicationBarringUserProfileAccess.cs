using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for accessing the user Communication Barring user profile configuration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminCommunicationBarringUserProfileAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "None")]
        None,
    }
}
