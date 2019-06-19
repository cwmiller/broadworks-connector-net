using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Options for call center enhanced reporting input parameters.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportInputParameterOption
    {
        [XmlEnum(Name = "Required")]
        Required,
        [XmlEnum(Name = "Hidden")]
        Hidden,
    }
}
