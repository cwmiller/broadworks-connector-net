using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Internal Call CLID Policy applicable to service providers.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderInternalCallsCLIDPolicy    {
            [XmlEnum(Name = "Use Extension")]
        UseExtension,
            [XmlEnum(Name = "Use External Calls Policy")]
        UseExternalCallsPolicy,
     }
}
