using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The action performed by a device management event.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventAction    {
            [XmlEnum(Name = "Delete")]
        Delete,
            [XmlEnum(Name = "Download")]
        Download,
            [XmlEnum(Name = "Rebuild")]
        Rebuild,
            [XmlEnum(Name = "Reset")]
        Reset,
            [XmlEnum(Name = "Upload")]
        Upload,
     }
}
