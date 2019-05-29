using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobileManagerModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "scfApiNetAddress1", IsNullable = true)]
    public string ScfApiNetAddress1 { get; set; }
    [XmlElement(ElementName = "scfApiNetAddress2", IsNullable = true)]
    public string ScfApiNetAddress2 { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = true)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = true)]
    public string Password { get; set; }
    [XmlElement(ElementName = "emailFromAddress", IsNullable = true)]
    public string EmailFromAddress { get; set; }
    [XmlElement(ElementName = "scfIMSOnly", IsNullable = false)]
    public bool ScfIMSOnly { get; set; }
    [XmlElement(ElementName = "signalingIPAddress", IsNullable = true)]
    public string SignalingIPAddress { get; set; }
    [XmlElement(ElementName = "signalingPort", IsNullable = true)]
    public int? SignalingPort { get; set; }
 }
}
