using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSequentialRingGetResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadworksConnector.Ocip.Models.SequentialRingNumberOfRings _baseLocationNumberOfRings;

    [XmlElement(ElementName = "baseLocationNumberOfRings", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingNumberOfRings BaseLocationNumberOfRings {
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
    private BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 _location01;

    [XmlElement(ElementName = "Location01", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 Location01 {
        get => _location01;
        set {
            Location01Specified = true;
            _location01 = value;
        }
    }

    [XmlIgnore]
    public bool Location01Specified { get; set; }
    private BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 _location02;

    [XmlElement(ElementName = "Location02", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 Location02 {
        get => _location02;
        set {
            Location02Specified = true;
            _location02 = value;
        }
    }

    [XmlIgnore]
    public bool Location02Specified { get; set; }
    private BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 _location03;

    [XmlElement(ElementName = "Location03", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 Location03 {
        get => _location03;
        set {
            Location03Specified = true;
            _location03 = value;
        }
    }

    [XmlIgnore]
    public bool Location03Specified { get; set; }
    private BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 _location04;

    [XmlElement(ElementName = "Location04", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 Location04 {
        get => _location04;
        set {
            Location04Specified = true;
            _location04 = value;
        }
    }

    [XmlIgnore]
    public bool Location04Specified { get; set; }
    private BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 _location05;

    [XmlElement(ElementName = "Location05", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SequentialRingLocation14sp4 Location05 {
        get => _location05;
        set {
            Location05Specified = true;
            _location05 = value;
        }
    }

    [XmlIgnore]
    public bool Location05Specified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _criteriaTable;

    [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable {
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
