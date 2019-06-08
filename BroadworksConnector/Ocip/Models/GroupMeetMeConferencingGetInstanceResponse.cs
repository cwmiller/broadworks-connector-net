using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

    [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts {
        get => _allocatedPorts;
        set {
            AllocatedPortsSpecified = true;
            _allocatedPorts = value;
        }
    }

    [XmlIgnore]
    public bool AllocatedPortsSpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private bool _allowIndividualOutDial;

    [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
    public bool AllowIndividualOutDial {
        get => _allowIndividualOutDial;
        set {
            AllowIndividualOutDialSpecified = true;
            _allowIndividualOutDial = value;
        }
    }

    [XmlIgnore]
    public bool AllowIndividualOutDialSpecified { get; set; }
    private string _operatorNumber;

    [XmlElement(ElementName = "operatorNumber", IsNullable = false, Namespace = "")]
    public string OperatorNumber {
        get => _operatorNumber;
        set {
            OperatorNumberSpecified = true;
            _operatorNumber = value;
        }
    }

    [XmlIgnore]
    public bool OperatorNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceHostUserTable;

    [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable {
        get => _conferenceHostUserTable;
        set {
            ConferenceHostUserTableSpecified = true;
            _conferenceHostUserTable = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceHostUserTableSpecified { get; set; }
}
}
