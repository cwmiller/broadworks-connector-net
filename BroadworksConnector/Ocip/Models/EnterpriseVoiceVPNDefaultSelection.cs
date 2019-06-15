using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Default Selector.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNDefaultSelection    {
            [XmlEnum(Name = "Public")]
        Public,
            [XmlEnum(Name = "Private")]
        Private,
     }
}
