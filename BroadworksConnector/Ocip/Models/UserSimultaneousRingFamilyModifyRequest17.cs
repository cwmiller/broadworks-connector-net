using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingFamilyModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _doNotRingIfOnCall;

    [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false, Namespace = "")]
    public bool DoNotRingIfOnCall {
        get => _doNotRingIfOnCall;
        set {
            DoNotRingIfOnCallSpecified = true;
            _doNotRingIfOnCall = value;
        }
    }

    [XmlIgnore]
    public bool DoNotRingIfOnCallSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SimultaneousRingReplacementNumberList _simultaneousRingNumberList;

    [XmlElement(ElementName = "simultaneousRingNumberList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SimultaneousRingReplacementNumberList SimultaneousRingNumberList {
        get => _simultaneousRingNumberList;
        set {
            SimultaneousRingNumberListSpecified = true;
            _simultaneousRingNumberList = value;
        }
    }

    [XmlIgnore]
    public bool SimultaneousRingNumberListSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
        get => _criteriaActivation;
        set {
            CriteriaActivationSpecified = true;
            _criteriaActivation = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaActivationSpecified { get; set; }
}
}
