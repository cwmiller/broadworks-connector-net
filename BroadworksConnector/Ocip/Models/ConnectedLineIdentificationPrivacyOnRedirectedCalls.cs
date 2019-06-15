using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Connected Line Identification Privacy on Redirected Calls
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ConnectedLineIdentificationPrivacyOnRedirectedCalls    {
            [XmlEnum(Name = "No Privacy")]
        NoPrivacy,
            [XmlEnum(Name = "Privacy For External Calls")]
        PrivacyForExternalCalls,
            [XmlEnum(Name = "Privacy For All Calls")]
        PrivacyForAllCalls,
     }
}
