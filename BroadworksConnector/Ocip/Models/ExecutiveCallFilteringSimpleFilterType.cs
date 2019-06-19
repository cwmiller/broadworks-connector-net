using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive call filtering filter type in simple filtering mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveCallFilteringSimpleFilterType
    {
        [XmlEnum(Name = "All Calls")]
        AllCalls,
        [XmlEnum(Name = "All Internal Calls")]
        AllInternalCalls,
        [XmlEnum(Name = "All External Calls")]
        AllExternalCalls,
    }
}
