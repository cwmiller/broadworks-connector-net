using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetInstanceResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile {
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

    [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = false, Namespace = "")]
    public string OriginatorCLIDPrefix {
        get => _originatorCLIDPrefix;
        set {
            OriginatorCLIDPrefixSpecified = true;
            _originatorCLIDPrefix = value;
        }
    }

    [XmlIgnore]
    public bool OriginatorCLIDPrefixSpecified { get; set; }
}
}
