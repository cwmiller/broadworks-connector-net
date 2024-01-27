using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The status of a Device Management File Authentication.
    /// The possible values are:
    /// "Challenge" : authentication is required.
    /// "Need Digest Authentication" : client needs to use digest authentication.
    /// "Need User Password Authentication" : client needs to use user/pass authentication.
    /// "Need Bearer Authentication" : client needs to use bearer authentication.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileAuthenticationStatus
    {
        [XmlEnum(Name = "Challenge")]
        Challenge,
        [XmlEnum(Name = "Need Digest Authentication")]
        NeedDigestAuthentication,
        [XmlEnum(Name = "Need User Password Authentication")]
        NeedUserPasswordAuthentication,
        [XmlEnum(Name = "Need Bearer Authentication")]
        NeedBearerAuthentication,
    }
}
