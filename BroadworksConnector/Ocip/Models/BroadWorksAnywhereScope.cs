using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Controls which users may use the BroadWorks Anywhere portal.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksAnywhereScope    {
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
