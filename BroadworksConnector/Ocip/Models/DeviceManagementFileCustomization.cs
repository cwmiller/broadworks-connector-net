using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Controls the file customization privileges.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileCustomization    {
            [XmlEnum(Name = "Disallow")]
        Disallow,
            [XmlEnum(Name = "Administrator")]
        Administrator,
            [XmlEnum(Name = "Administrator and User")]
        AdministratorandUser,
     }
}
