using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AnnouncementRecordingMenuKeys 
{
    [XmlElement(ElementName = "acceptRecording", IsNullable = false)]
    public string AcceptRecording { get; set; }
    [XmlElement(ElementName = "rejectRerecord", IsNullable = false)]
    public string RejectRerecord { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
    [XmlElement(ElementName = "end", IsNullable = false)]
    public string End { get; set; }
 }
}
