using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for accessing group level and user level calling plan configuration.
    /// "Full" provides full control over the configuration of group-level and user-level calling plans.
    /// "Restricted" indicates
    /// 1) not to provide access to group-level calling plan configuration,
    /// 2) to provide access to only collect calls for user level incoming calling plan,
    /// 3) to provide access to only international, operator assisted, 700/900, 976, and casual calls for user level outgoing calling plan.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupCallingPlanAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Restricted")]
        Restricted,
     }
}
