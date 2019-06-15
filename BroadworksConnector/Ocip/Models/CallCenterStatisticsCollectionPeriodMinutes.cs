using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Statistics reporting interval in minutes.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStatisticsCollectionPeriodMinutes    {
            [XmlEnum(Name = "15")]
        _15,
            [XmlEnum(Name = "30")]
        _30,
            [XmlEnum(Name = "60")]
        _60,
     }
}
