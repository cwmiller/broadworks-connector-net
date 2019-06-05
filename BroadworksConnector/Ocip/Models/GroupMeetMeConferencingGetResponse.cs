using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts _availablePorts;

    [XmlElement(ElementName = "availablePorts", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AvailablePorts {
        get => _availablePorts;
        set {
            AvailablePortsSpecified = true;
            _availablePorts = value;
        }
    }

    [XmlIgnore]
    public bool AvailablePortsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

    [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts {
        get => _allocatedPorts;
        set {
            AllocatedPortsSpecified = true;
            _allocatedPorts = value;
        }
    }

    [XmlIgnore]
    public bool AllocatedPortsSpecified { get; set; }
}
}
