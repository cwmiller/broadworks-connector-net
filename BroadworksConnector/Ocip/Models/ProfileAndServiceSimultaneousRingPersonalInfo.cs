using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceSimultaneousRingPersonalInfo 
{
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
    private List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> _simultaneousRingNumber;

    [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber {
        get => _simultaneousRingNumber;
        set {
            SimultaneousRingNumberSpecified = true;
            _simultaneousRingNumber = value;
        }
    }

    [XmlIgnore]
    public bool SimultaneousRingNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

    [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable {
        get => _criteriaTable;
        set {
            CriteriaTableSpecified = true;
            _criteriaTable = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaTableSpecified { get; set; }
}
}