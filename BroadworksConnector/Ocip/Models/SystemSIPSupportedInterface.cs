using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Network Server types.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemSIPSupportedInterface    {
            [XmlEnum(Name = "Access")]
        Access,
            [XmlEnum(Name = "Network")]
        Network,
            [XmlEnum(Name = "Both")]
        Both,
     }
}
