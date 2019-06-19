using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Push to talk access list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PushToTalkAccessListSelection
    {
        [XmlEnum(Name = "Allow Calls From Selected Users")]
        AllowCallsFromSelectedUsers,
        [XmlEnum(Name = "Allow Calls From Everyone Except Selected Users")]
        AllowCallsFromEveryoneExceptSelectedUsers,
    }
}
