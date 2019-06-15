using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The file category for an access device file managed by the Device Management System on BroadWorks. A static file has no variable content and only one copy is required on the repository.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileCategory    {
            [XmlEnum(Name = "Static")]
        Static,
            [XmlEnum(Name = "Dynamic Group")]
        DynamicGroup,
            [XmlEnum(Name = "Dynamic Profile")]
        DynamicProfile,
     }
}
