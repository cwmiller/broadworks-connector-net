using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMeetMeConferencingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
