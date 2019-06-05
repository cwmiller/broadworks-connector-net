using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GETSPriorityClass
    {
        [XmlEnum(Name = "GETS-Mandatory")]
        GETSMandatory,
        [XmlEnum(Name = "GETS")]
        GETS,
    }
}
