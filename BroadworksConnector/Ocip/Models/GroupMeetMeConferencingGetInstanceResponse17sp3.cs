using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetInstanceResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "allocatedPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false)]
    public bool AllowIndividualOutDial { get; set; }
    [XmlElement(ElementName = "operatorNumber", IsNullable = false)]
    public string OperatorNumber { get; set; }
    [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable { get; set; }
 }
}
