using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSequentialRingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _ringBaseLocationFirst;

    [XmlElement(ElementName = "ringBaseLocationFirst", IsNullable = false, Namespace = "")]
    public bool RingBaseLocationFirst {
        get => _ringBaseLocationFirst;
        set {
            RingBaseLocationFirstSpecified = true;
            _ringBaseLocationFirst = value;
        }
    }

    [XmlIgnore]
    public bool RingBaseLocationFirstSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings _baseLocationNumberOfRings;

    [XmlElement(ElementName = "baseLocationNumberOfRings", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings BaseLocationNumberOfRings {
        get => _baseLocationNumberOfRings;
        set {
            BaseLocationNumberOfRingsSpecified = true;
            _baseLocationNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool BaseLocationNumberOfRingsSpecified { get; set; }
    private bool _continueIfBaseLocationIsBusy;

    [XmlElement(ElementName = "continueIfBaseLocationIsBusy", IsNullable = false, Namespace = "")]
    public bool ContinueIfBaseLocationIsBusy {
        get => _continueIfBaseLocationIsBusy;
        set {
            ContinueIfBaseLocationIsBusySpecified = true;
            _continueIfBaseLocationIsBusy = value;
        }
    }

    [XmlIgnore]
    public bool ContinueIfBaseLocationIsBusySpecified { get; set; }
    private bool _callerMayStopSearch;

    [XmlElement(ElementName = "callerMayStopSearch", IsNullable = false, Namespace = "")]
    public bool CallerMayStopSearch {
        get => _callerMayStopSearch;
        set {
            CallerMayStopSearchSpecified = true;
            _callerMayStopSearch = value;
        }
    }

    [XmlIgnore]
    public bool CallerMayStopSearchSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location01;

    [XmlElement(ElementName = "Location01", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location01 {
        get => _location01;
        set {
            Location01Specified = true;
            _location01 = value;
        }
    }

    [XmlIgnore]
    public bool Location01Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location02;

    [XmlElement(ElementName = "Location02", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location02 {
        get => _location02;
        set {
            Location02Specified = true;
            _location02 = value;
        }
    }

    [XmlIgnore]
    public bool Location02Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location03;

    [XmlElement(ElementName = "Location03", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location03 {
        get => _location03;
        set {
            Location03Specified = true;
            _location03 = value;
        }
    }

    [XmlIgnore]
    public bool Location03Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location04;

    [XmlElement(ElementName = "Location04", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location04 {
        get => _location04;
        set {
            Location04Specified = true;
            _location04 = value;
        }
    }

    [XmlIgnore]
    public bool Location04Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location05;

    [XmlElement(ElementName = "Location05", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location05 {
        get => _location05;
        set {
            Location05Specified = true;
            _location05 = value;
        }
    }

    [XmlIgnore]
    public bool Location05Specified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
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