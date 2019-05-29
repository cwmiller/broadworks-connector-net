using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessageSummaryUpdateModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "sendSavedAndUrgentMWIOnNotification", IsNullable = false)]
    public bool SendSavedAndUrgentMWIOnNotification { get; set; }
    [XmlElement(ElementName = "sendMessageSummaryUpdateOnRegister", IsNullable = false)]
    public bool SendMessageSummaryUpdateOnRegister { get; set; }
    [XmlElement(ElementName = "minTimeBetweenMWIOnRegister", IsNullable = false)]
    public int MinTimeBetweenMWIOnRegister { get; set; }
 }
}
