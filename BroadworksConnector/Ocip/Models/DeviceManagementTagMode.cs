using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Defines the tag sets used when device configuration files are built.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementTagMode    {
            [XmlEnum(Name = "None")]
        None,
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "System And Custom")]
        SystemAndCustom,
     }
}
