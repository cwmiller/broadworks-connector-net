using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEnhancedReportingBrandingChoice
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Custom")]
        Custom,
    }
}
