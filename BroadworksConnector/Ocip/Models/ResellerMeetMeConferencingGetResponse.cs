using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _conferenceFromAddress;

    [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
    public string ConferenceFromAddress {
        get => _conferenceFromAddress;
        set {
            ConferenceFromAddressSpecified = true;
            _conferenceFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceFromAddressSpecified { get; set; }
    private int _maxAllocatedPorts;

    [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false, Namespace = "")]
    public int MaxAllocatedPorts {
        get => _maxAllocatedPorts;
        set {
            MaxAllocatedPortsSpecified = true;
            _maxAllocatedPorts = value;
        }
    }

    [XmlIgnore]
    public bool MaxAllocatedPortsSpecified { get; set; }
}
}
