using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    private BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _destinationPhoneNumberList;

    [XmlElement(ElementName = "destinationPhoneNumberList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList DestinationPhoneNumberList {
        get => _destinationPhoneNumberList;
        set {
            DestinationPhoneNumberListSpecified = true;
            _destinationPhoneNumberList = value;
        }
    }

    [XmlIgnore]
    public bool DestinationPhoneNumberListSpecified { get; set; }
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
    private int? _answerTimeoutMinutes;

    [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = true, Namespace = "")]
    public int? AnswerTimeoutMinutes {
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
