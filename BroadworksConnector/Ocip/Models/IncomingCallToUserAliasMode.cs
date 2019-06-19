using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User alias usage mode for AS translations on incoming calls.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum IncomingCallToUserAliasMode
    {
        [XmlEnum(Name = "Enabled")]
        Enabled,
        [XmlEnum(Name = "ExplicitAlias")]
        ExplicitAlias,
        [XmlEnum(Name = "Disabled")]
        Disabled,
    }
}
