using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Type of Network for the call provided in the most significant contact from the NS
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NetworkType
    {
        [XmlEnum(Name = "Private")]
        Private,
        [XmlEnum(Name = "Public")]
        Public,
    }
}
