using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceGreetingResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false)]
    public bool PlayEntranceGreeting { get; set; }
    [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey EntranceGreetingFile { get; set; }
 }
}
