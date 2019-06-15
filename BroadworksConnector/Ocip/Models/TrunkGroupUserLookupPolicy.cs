using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group User Lookup Policy in performing the trunk group user screening process for a trunk call.
    /// "Basic" indicates the lookup is performed using FROM header only.
    /// "Extended" indicates the lookup is performed in the precedence order of P-Preferred-Identity header,
    /// P-Asserted-Identity header, Remote-Party-ID header, and FROM header.
    /// "Basic Lookup Prefer From"
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupUserLookupPolicy    {
            [XmlEnum(Name = "Basic")]
        Basic,
            [XmlEnum(Name = "Extended")]
        Extended,
            [XmlEnum(Name = "Basic Lookup Prefer From")]
        BasicLookupPreferFrom,
     }
}
