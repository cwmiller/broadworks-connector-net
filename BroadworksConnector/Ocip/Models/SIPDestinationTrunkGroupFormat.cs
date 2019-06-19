using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for destination trunk group format.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPDestinationTrunkGroupFormat
    {
        [XmlEnum(Name = "DTG")]
        DTG,
        [XmlEnum(Name = "Tgrp In Contact")]
        TgrpInContact,
        [XmlEnum(Name = "Tgrp In Request URI")]
        TgrpInRequestURI,
        [XmlEnum(Name = "X Nortel Profile")]
        XNortelProfile,
    }
}
