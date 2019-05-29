using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allocatedPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts { get; set; }
 }
}
