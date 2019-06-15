using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting template access option.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportTemplateAccessOption    {
            [XmlEnum(Name = "Supervisor Only")]
        SupervisorOnly,
            [XmlEnum(Name = "Supervisor and Agent")]
        SupervisorandAgent,
     }
}
