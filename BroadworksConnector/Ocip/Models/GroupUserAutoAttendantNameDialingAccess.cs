using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for a user's access to the name dialing override fields.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupUserAutoAttendantNameDialingAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
