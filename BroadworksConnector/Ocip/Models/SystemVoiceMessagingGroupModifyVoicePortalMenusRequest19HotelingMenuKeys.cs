using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19HotelingMenuKeys 
{
    [XmlElement(ElementName = "checkHostStatus", IsNullable = true)]
    public string CheckHostStatus { get; set; }
    [XmlElement(ElementName = "associateWithHost", IsNullable = true)]
    public string AssociateWithHost { get; set; }
    [XmlElement(ElementName = "disassociateFromHost", IsNullable = true)]
    public string DisassociateFromHost { get; set; }
    [XmlElement(ElementName = "disassociateFromRemoteHost", IsNullable = true)]
    public string DisassociateFromRemoteHost { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
