using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMPPGetResponse14sp5 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = false)]
    public string PrimarySMPPServerNetAddress { get; set; }
    [XmlElement(ElementName = "primarySMPPPort", IsNullable = false)]
    public int PrimarySMPPPort { get; set; }
    [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = false)]
    public string SecondarySMPPServerNetAddress { get; set; }
    [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false)]
    public int SecondarySMPPPort { get; set; }
    [XmlElement(ElementName = "systemId", IsNullable = false)]
    public string SystemId { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "version", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SMPPVersion Version { get; set; }
    [XmlElement(ElementName = "systemType", IsNullable = false)]
    public string SystemType { get; set; }
 }
}
