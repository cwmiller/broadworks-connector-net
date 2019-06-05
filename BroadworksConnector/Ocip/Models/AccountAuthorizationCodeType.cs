using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccountAuthorizationCodeType
    {
        [XmlEnum(Name = "Account Code")]
        AccountCode,
        [XmlEnum(Name = "Authorization Code")]
        AuthorizationCode,
        [XmlEnum(Name = "Deactivated")]
        Deactivated,
    }
}
