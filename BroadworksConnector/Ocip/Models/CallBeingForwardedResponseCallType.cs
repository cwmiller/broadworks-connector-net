using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call type choices for sending call being forward response on Redirected Calls
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallBeingForwardedResponseCallType    {
            [XmlEnum(Name = "Never")]
        Never,
            [XmlEnum(Name = "Internal Calls")]
        InternalCalls,
            [XmlEnum(Name = "All Calls")]
        AllCalls,
     }
}
