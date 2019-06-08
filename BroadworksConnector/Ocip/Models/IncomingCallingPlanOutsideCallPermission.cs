using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum IncomingCallingPlanOutsideCallPermission{
    [XmlEnum(Name = "Allow")]
    Allow,
    [XmlEnum(Name = "Allow Only If Redirected From Another User")]
    AllowOnlyIfRedirectedFromAnotherUser,
    [XmlEnum(Name = "Disallow")]
    Disallow,
 }
}
