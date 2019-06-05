using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEnhancedReportingSystemBrandingChoice
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Custom")]
        Custom,
    }
}
