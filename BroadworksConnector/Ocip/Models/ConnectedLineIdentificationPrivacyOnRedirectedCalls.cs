using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ConnectedLineIdentificationPrivacyOnRedirectedCalls{
    [XmlEnum(Name = "No Privacy")]
    NoPrivacy,
    [XmlEnum(Name = "Privacy For External Calls")]
    PrivacyForExternalCalls,
    [XmlEnum(Name = "Privacy For All Calls")]
    PrivacyForAllCalls,
 }
}
