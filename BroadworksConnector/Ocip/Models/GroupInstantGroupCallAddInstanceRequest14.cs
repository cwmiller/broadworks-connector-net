using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallAddInstanceRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _destinationPhoneNumber;

    [XmlElement(ElementName = "destinationPhoneNumber", IsNullable = false, Namespace = "")]
    public List<string> DestinationPhoneNumber {
        get => _destinationPhoneNumber;
        set {
            DestinationPhoneNumberSpecified = true;
            _destinationPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool DestinationPhoneNumberSpecified { get; set; }
    private bool _isAnswerTimeoutEnabled;

    [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false, Namespace = "")]
    public bool IsAnswerTimeoutEnabled {
        get => _isAnswerTimeoutEnabled;
        set {
            IsAnswerTimeoutEnabledSpecified = true;
            _isAnswerTimeoutEnabled = value;
        }
    }

    [XmlIgnore]
    public bool IsAnswerTimeoutEnabledSpecified { get; set; }
    private int _answerTimeoutMinutes;

    [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = false, Namespace = "")]
    public int AnswerTimeoutMinutes {
        get => _answerTimeoutMinutes;
        set {
            AnswerTimeoutMinutesSpecified = true;
            _answerTimeoutMinutes = value;
        }
    }

    [XmlIgnore]
    public bool AnswerTimeoutMinutesSpecified { get; set; }
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
}
}
