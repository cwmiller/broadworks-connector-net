using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20DeleteAllMessagesMenuKeys 
{
    [XmlElement(ElementName = "confirmDeletion", IsNullable = false)]
    public string ConfirmDeletion { get; set; }
    [XmlElement(ElementName = "cancelDeletion", IsNullable = false)]
    public string CancelDeletion { get; set; }
 }
}
