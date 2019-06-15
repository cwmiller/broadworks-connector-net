using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group CLID Source for Screened Trunk Calls Policy.
    /// "Profile Name Profile Number" indicates CLID uses name and number from screened user profile.
    /// "Received Name Profile Number" indicates CLID uses name in FROM header and number from screened user profile.
    /// "Received Name Received Number" indicates CLID uses name and number in FROM header.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupCLIDSourceForScreenedCallsPolicy    {
            [XmlEnum(Name = "Profile Name Profile Number")]
        ProfileNameProfileNumber,
            [XmlEnum(Name = "Received Name Profile Number")]
        ReceivedNameProfileNumber,
            [XmlEnum(Name = "Received Name Received Number")]
        ReceivedNameReceivedNumber,
     }
}
