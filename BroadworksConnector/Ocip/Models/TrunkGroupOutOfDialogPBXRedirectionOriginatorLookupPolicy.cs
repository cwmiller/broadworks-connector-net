using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group out-of-dialog PBX Redirection Originator Lookup policy.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupOutOfDialogPBXRedirectionOriginatorLookupPolicy    {
            [XmlEnum(Name = "Asserted")]
        Asserted,
            [XmlEnum(Name = "Presentation")]
        Presentation,
            [XmlEnum(Name = "Asserted Or Presentation")]
        AssertedOrPresentation,
     }
}
