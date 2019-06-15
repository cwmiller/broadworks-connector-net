using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for calling party category format.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPCallingPartyCategoryFormat    {
            [XmlEnum(Name = "CPC")]
        CPC,
            [XmlEnum(Name = "ISUP OLI")]
        ISUPOLI,
            [XmlEnum(Name = "CPC GTD")]
        CPCGTD,
     }
}
