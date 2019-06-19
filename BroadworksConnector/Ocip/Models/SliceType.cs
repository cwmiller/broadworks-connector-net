using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the Slice type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SliceType
    {
        [XmlEnum(Name = "Call Processing")]
        CallProcessing,
        [XmlEnum(Name = "Provisioning")]
        Provisioning,
    }
}
