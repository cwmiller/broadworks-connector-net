using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMPPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = true)]
    public string PrimarySMPPServerNetAddress { get; set; }
    [XmlElement(ElementName = "primarySMPPPort", IsNullable = false)]
    public int PrimarySMPPPort { get; set; }
    [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = true)]
    public string SecondarySMPPServerNetAddress { get; set; }
    [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false)]
    public int SecondarySMPPPort { get; set; }
    [XmlElement(ElementName = "systemId", IsNullable = true)]
    public string SystemId { get; set; }
    [XmlElement(ElementName = "password", IsNullable = true)]
    public string Password { get; set; }
    [XmlElement(ElementName = "version", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SMPPVersion Version { get; set; }
    [XmlElement(ElementName = "systemType", IsNullable = true)]
    public string SystemType { get; set; }
    [XmlElement(ElementName = "enableMWICustomizedMessage", IsNullable = false)]
    public bool EnableMWICustomizedMessage { get; set; }
    [XmlElement(ElementName = "supportMessagePayload", IsNullable = false)]
    public bool SupportMessagePayload { get; set; }
    [XmlElement(ElementName = "maxShortMessageLength", IsNullable = false)]
    public int MaxShortMessageLength { get; set; }
    [XmlElement(ElementName = "useGsmMwiUcs2Encoding", IsNullable = false)]
    public bool UseGsmMwiUcs2Encoding { get; set; }
    [XmlElement(ElementName = "includeOnlyNewMessageCount", IsNullable = false)]
    public bool IncludeOnlyNewMessageCount { get; set; }
 }
}
