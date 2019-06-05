using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
