using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventAction
    {
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
