using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallGetInstanceResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile {
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
