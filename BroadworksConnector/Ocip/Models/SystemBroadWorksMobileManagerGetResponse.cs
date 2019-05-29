using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobileManagerGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scfApiNetAddress1", IsNullable = false)]
    public string ScfApiNetAddress1 { get; set; }
    [XmlElement(ElementName = "scfApiNetAddress2", IsNullable = false)]
    public string ScfApiNetAddress2 { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "emailFromAddress", IsNullable = false)]
    public string EmailFromAddress { get; set; }
    [XmlElement(ElementName = "scfIMSOnly", IsNullable = false)]
    public bool ScfIMSOnly { get; set; }
    [XmlElement(ElementName = "signalingIPAddress", IsNullable = false)]
    public string SignalingIPAddress { get; set; }
    [XmlElement(ElementName = "signalingPort", IsNullable = false)]
    public int SignalingPort { get; set; }
 }
}
