using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Type of Alternate Carriers available for CbC and Preselection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HPBXAlternateCarrierType
    {
        [XmlEnum(Name = "Local And Distant")]
        LocalAndDistant,
        [XmlEnum(Name = "Distant")]
        Distant,
    }
}
