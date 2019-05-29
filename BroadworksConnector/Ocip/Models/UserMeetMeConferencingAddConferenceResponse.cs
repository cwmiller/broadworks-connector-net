using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingAddConferenceResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceId", IsNullable = false)]
    public string ConferenceId { get; set; }
    [XmlElement(ElementName = "moderatorPin", IsNullable = false)]
    public string ModeratorPin { get; set; }
 }
}
