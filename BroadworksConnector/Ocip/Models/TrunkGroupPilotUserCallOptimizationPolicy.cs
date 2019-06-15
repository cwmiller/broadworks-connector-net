using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group Pilot User Call Optimization Policy
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupPilotUserCallOptimizationPolicy    {
            [XmlEnum(Name = "Optimize For User Services")]
        OptimizeForUserServices,
            [XmlEnum(Name = "Optimize For High Call Volume")]
        OptimizeForHighCallVolume,
     }
}
