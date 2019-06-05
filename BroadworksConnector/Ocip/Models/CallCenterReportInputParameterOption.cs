using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
