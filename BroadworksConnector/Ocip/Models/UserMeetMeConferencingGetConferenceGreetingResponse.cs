using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceGreetingResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false)]
    public bool PlayEntranceGreeting { get; set; }
    [XmlElement(ElementName = "entranceGreetingAudioFile", IsNullable = false)]
    public string EntranceGreetingAudioFile { get; set; }
    [XmlElement(ElementName = "entranceGreetingMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType EntranceGreetingMediaType { get; set; }
 }
}
