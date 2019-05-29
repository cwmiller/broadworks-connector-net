using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SendToAllGroupMembersMenuKeysReadEntry 
{
    [XmlElement(ElementName = "confirmSendingToEntireGroup", IsNullable = false)]
    public string ConfirmSendingToEntireGroup { get; set; }
    [XmlElement(ElementName = "cancelSendingToEntireGroup", IsNullable = false)]
    public string CancelSendingToEntireGroup { get; set; }
 }
}
