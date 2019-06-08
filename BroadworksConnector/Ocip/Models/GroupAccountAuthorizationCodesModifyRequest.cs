using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccountAuthorizationCodesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType _codeType;

    [XmlElement(ElementName = "codeType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType CodeType {
        get => _codeType;
        set {
            CodeTypeSpecified = true;
            _codeType = value;
        }
    }

    [XmlIgnore]
    public bool CodeTypeSpecified { get; set; }
    private int _numberOfDigits;

    [XmlElement(ElementName = "numberOfDigits", IsNullable = false, Namespace = "")]
    public int NumberOfDigits {
        get => _numberOfDigits;
        set {
            NumberOfDigitsSpecified = true;
            _numberOfDigits = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfDigitsSpecified { get; set; }
    private bool _allowLocalAndTollFreeCalls;

    [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false, Namespace = "")]
    public bool AllowLocalAndTollFreeCalls {
        get => _allowLocalAndTollFreeCalls;
        set {
            AllowLocalAndTollFreeCallsSpecified = true;
            _allowLocalAndTollFreeCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowLocalAndTollFreeCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _mandatoryUsageUserIdList;

    [XmlElement(ElementName = "mandatoryUsageUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList MandatoryUsageUserIdList {
        get => _mandatoryUsageUserIdList;
        set {
            MandatoryUsageUserIdListSpecified = true;
            _mandatoryUsageUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool MandatoryUsageUserIdListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _optionalUsageUserIdList;

    [XmlElement(ElementName = "optionalUsageUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList OptionalUsageUserIdList {
        get => _optionalUsageUserIdList;
        set {
            OptionalUsageUserIdListSpecified = true;
            _optionalUsageUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool OptionalUsageUserIdListSpecified { get; set; }
}
}
