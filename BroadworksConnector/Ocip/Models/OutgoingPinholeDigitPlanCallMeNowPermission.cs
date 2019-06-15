using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Permission choices for Pinhole digit patterns on Call Me Now calls.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum OutgoingPinholeDigitPlanCallMeNowPermission    {
            [XmlEnum(Name = "Ignore")]
        Ignore,
            [XmlEnum(Name = "Allow")]
        Allow,
     }
}
