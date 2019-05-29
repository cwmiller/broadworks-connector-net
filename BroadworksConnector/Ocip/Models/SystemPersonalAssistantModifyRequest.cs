using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPersonalAssistantModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "transferToAttendantKey", IsNullable = false)]
    public string TransferToAttendantKey { get; set; }
    [XmlElement(ElementName = "transferToVoiceMessagingKey", IsNullable = false)]
    public string TransferToVoiceMessagingKey { get; set; }
 }
}
