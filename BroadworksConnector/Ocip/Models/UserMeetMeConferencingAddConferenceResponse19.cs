using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingAddConferenceResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceId", IsNullable = false)]
    public string ConferenceId { get; set; }
    [XmlElement(ElementName = "moderatorPin", IsNullable = false)]
    public string ModeratorPin { get; set; }
    [XmlElement(ElementName = "securityPin", IsNullable = false)]
    public string SecurityPin { get; set; }
 }
}
