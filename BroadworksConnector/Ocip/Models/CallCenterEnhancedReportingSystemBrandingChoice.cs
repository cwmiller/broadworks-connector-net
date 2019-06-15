using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting system level branding choice.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEnhancedReportingSystemBrandingChoice    {
            [XmlEnum(Name = "Default")]
        Default,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
