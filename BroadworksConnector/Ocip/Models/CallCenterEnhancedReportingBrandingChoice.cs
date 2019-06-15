using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting Enterprise or Group level branding choice.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEnhancedReportingBrandingChoice    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
