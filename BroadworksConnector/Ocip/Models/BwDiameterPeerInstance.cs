using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The diameter peer instance type for an entry in the Peer Table.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BwDiameterPeerInstance    {
            [XmlEnum(Name = "XS")]
        XS,
            [XmlEnum(Name = "PS")]
        PS,
     }
}
