using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group user creation mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupUserCreationMode    {
            [XmlEnum(Name = "Extension")]
        Extension,
            [XmlEnum(Name = "Phone Number")]
        PhoneNumber,
     }
}
