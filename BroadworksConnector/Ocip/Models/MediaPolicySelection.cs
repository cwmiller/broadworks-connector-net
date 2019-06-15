using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Media Policy Selections.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MediaPolicySelection    {
            [XmlEnum(Name = "Use Uncompressed Codec")]
        UseUncompressedCodec,
            [XmlEnum(Name = "Use Supported Media Set")]
        UseSupportedMediaSet,
            [XmlEnum(Name = "No Restrictions")]
        NoRestrictions,
     }
}
