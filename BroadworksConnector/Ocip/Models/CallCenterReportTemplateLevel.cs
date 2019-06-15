using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies at which level in the system a call center report template is created.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportTemplateLevel    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Enterprise")]
        Enterprise,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
