using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SIPAuthenticationUserNamePassword 
{
    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false)]
    public string SipAuthenticationUserName { get; set; }
    [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false)]
    public string SipAuthenticationPassword { get; set; }
 }
}
