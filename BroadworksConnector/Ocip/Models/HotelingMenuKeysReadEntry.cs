using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class HotelingMenuKeysReadEntry 
{
    [XmlElement(ElementName = "checkHostStatus", IsNullable = false)]
    public string CheckHostStatus { get; set; }
    [XmlElement(ElementName = "associateWithHost", IsNullable = false)]
    public string AssociateWithHost { get; set; }
    [XmlElement(ElementName = "disassociateFromHost", IsNullable = false)]
    public string DisassociateFromHost { get; set; }
    [XmlElement(ElementName = "disassociateFromRemoteHost", IsNullable = false)]
    public string DisassociateFromRemoteHost { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
