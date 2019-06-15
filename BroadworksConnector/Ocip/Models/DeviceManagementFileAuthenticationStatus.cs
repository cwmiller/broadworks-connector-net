using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The status of a Device Management File Authentication.
    /// The possible values are:
    /// "Challenge" : authentication is required.
    /// "Need Digest Authntication" : client needs to use digest authentication.
    /// "Need User Password Authntication" : client needs to use user/pass authentication.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileAuthenticationStatus    {
            [XmlEnum(Name = "Challenge")]
        Challenge,
            [XmlEnum(Name = "Need Digest Authentication")]
        NeedDigestAuthentication,
            [XmlEnum(Name = "Need User Password Authentication")]
        NeedUserPasswordAuthentication,
     }
}
