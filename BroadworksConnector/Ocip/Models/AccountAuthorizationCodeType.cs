using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Account/Authorization Code Type.
    /// </summary>
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
