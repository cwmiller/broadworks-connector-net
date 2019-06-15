using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to Verify Translation and Routing feature.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminVerifyTranslationAndRoutingAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
