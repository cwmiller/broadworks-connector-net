using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of Endpoints in Broadworks.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RegistrationEndpointType    {
            [XmlEnum(Name = "Primary")]
        Primary,
            [XmlEnum(Name = "Shared Call Appearance")]
        SharedCallAppearance,
            [XmlEnum(Name = "Video Add On")]
        VideoAddOn,
     }
}
