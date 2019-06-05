using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportDataTemplateInputParameterOption
    {
        [XmlEnum(Name = "Required")]
        Required,
        [XmlEnum(Name = "Does Not Apply")]
        DoesNotApply,
    }
}
