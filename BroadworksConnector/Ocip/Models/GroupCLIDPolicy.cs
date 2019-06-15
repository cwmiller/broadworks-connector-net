using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Calling Line ID Policy Selections.
    /// NOTE:  The "Use Group CLID" value indicates the department CLID will be used if available otherwise the group CLID is used.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupCLIDPolicy    {
            [XmlEnum(Name = "Use DN")]
        UseDN,
            [XmlEnum(Name = "Use Configurable CLID")]
        UseConfigurableCLID,
            [XmlEnum(Name = "Use Group CLID")]
        UseGroupCLID,
     }
}
