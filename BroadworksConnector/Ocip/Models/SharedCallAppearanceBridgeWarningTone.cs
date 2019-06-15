using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Warning tone types for Shared Call Appearance.
    /// The bridge warning tone types are none, barge-in, barge-in repeat.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SharedCallAppearanceBridgeWarningTone    {
            [XmlEnum(Name = "None")]
        None,
            [XmlEnum(Name = "Barge-In")]
        BargeIn,
            [XmlEnum(Name = "Barge-In and Repeat")]
        BargeInandRepeat,
     }
}
