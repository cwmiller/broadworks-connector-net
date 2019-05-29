using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false)]
    public string ConferenceFromAddress { get; set; }
    [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false)]
    public int MaxAllocatedPorts { get; set; }
 }
}
