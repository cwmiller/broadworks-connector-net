using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Options for call center enhanced reporting data template input parameters.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportDataTemplateInputParameterOption    {
            [XmlEnum(Name = "Required")]
        Required,
            [XmlEnum(Name = "Does Not Apply")]
        DoesNotApply,
     }
}
