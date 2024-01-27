using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Define the leaf device category values.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LeafDeviceCategory
    {
        [XmlEnum(Name = "Handset")]
        Handset,
        [XmlEnum(Name = "Base Station")]
        BaseStation,
        [XmlEnum(Name = "All")]
        All,
    }
}
