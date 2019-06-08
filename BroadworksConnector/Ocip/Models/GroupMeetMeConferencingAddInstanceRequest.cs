using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
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
    private List<string> _conferenceHostUserId;

    [XmlElement(ElementName = "conferenceHostUserId", IsNullable = false, Namespace = "")]
    public List<string> ConferenceHostUserId {
        get => _conferenceHostUserId;
        set {
            ConferenceHostUserIdSpecified = true;
            _conferenceHostUserId = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceHostUserIdSpecified { get; set; }
}
}
