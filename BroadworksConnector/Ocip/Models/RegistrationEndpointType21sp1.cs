using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of Endpoints in Broadworks.
    /// 
    /// Change History
    /// R21.sp1 added Mobility
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RegistrationEndpointType21sp1    {
            [XmlEnum(Name = "Primary")]
        Primary,
            [XmlEnum(Name = "Shared Call Appearance")]
        SharedCallAppearance,
            [XmlEnum(Name = "Video Add On")]
        VideoAddOn,
            [XmlEnum(Name = "Mobility")]
        Mobility,
     }
}
