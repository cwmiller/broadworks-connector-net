using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availablePorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AvailablePorts { get; set; }
    [XmlElement(ElementName = "allocatedPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts { get; set; }
 }
}
