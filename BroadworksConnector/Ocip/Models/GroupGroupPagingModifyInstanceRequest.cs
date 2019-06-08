using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private int _confirmationToneTimeoutSeconds;

    [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int ConfirmationToneTimeoutSeconds {
        get => _confirmationToneTimeoutSeconds;
        set {
            ConfirmationToneTimeoutSecondsSpecified = true;
            _confirmationToneTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmationToneTimeoutSecondsSpecified { get; set; }
    private bool _deliverOriginatorCLIDInstead;

    [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false, Namespace = "")]
    public bool DeliverOriginatorCLIDInstead {
        get => _deliverOriginatorCLIDInstead;
        set {
            DeliverOriginatorCLIDInsteadSpecified = true;
            _deliverOriginatorCLIDInstead = value;
        }
    }

    [XmlIgnore]
    public bool DeliverOriginatorCLIDInsteadSpecified { get; set; }
    private string _originatorCLIDPrefix;

    [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = true, Namespace = "")]
    public string OriginatorCLIDPrefix {
        get => _originatorCLIDPrefix;
        set {
            OriginatorCLIDPrefixSpecified = true;
            _originatorCLIDPrefix = value;
        }
    }

    [XmlIgnore]
    public bool OriginatorCLIDPrefixSpecified { get; set; }
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
