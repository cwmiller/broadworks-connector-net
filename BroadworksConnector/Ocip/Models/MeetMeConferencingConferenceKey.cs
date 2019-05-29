using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceKey 
{
    [XmlElement(ElementName = "bridgeId", IsNullable = false)]
    public string BridgeId { get; set; }
    [XmlElement(ElementName = "conferenceId", IsNullable = false)]
    public string ConferenceId { get; set; }
 }
}
