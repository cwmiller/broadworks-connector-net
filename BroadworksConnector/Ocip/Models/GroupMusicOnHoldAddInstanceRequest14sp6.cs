using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldAddInstanceRequest14sp6 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private bool _isActiveDuringCallHold;

    [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false, Namespace = "")]
    public bool IsActiveDuringCallHold {
        get => _isActiveDuringCallHold;
        set {
            IsActiveDuringCallHoldSpecified = true;
            _isActiveDuringCallHold = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveDuringCallHoldSpecified { get; set; }
    private bool _isActiveDuringCallPark;

    [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false, Namespace = "")]
    public bool IsActiveDuringCallPark {
        get => _isActiveDuringCallPark;
        set {
            IsActiveDuringCallParkSpecified = true;
            _isActiveDuringCallPark = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveDuringCallParkSpecified { get; set; }
    private bool _isActiveDuringBusyCampOn;

    [XmlElement(ElementName = "isActiveDuringBusyCampOn", IsNullable = false, Namespace = "")]
    public bool IsActiveDuringBusyCampOn {
        get => _isActiveDuringBusyCampOn;
        set {
            IsActiveDuringBusyCampOnSpecified = true;
            _isActiveDuringBusyCampOn = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveDuringBusyCampOnSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd _source;

    [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd Source {
        get => _source;
        set {
            SourceSpecified = true;
            _source = value;
        }
    }

    [XmlIgnore]
    public bool SourceSpecified { get; set; }
    private bool _useAlternateSourceForInternalCalls;

    [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
    public bool UseAlternateSourceForInternalCalls {
        get => _useAlternateSourceForInternalCalls;
        set {
            UseAlternateSourceForInternalCallsSpecified = true;
            _useAlternateSourceForInternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseAlternateSourceForInternalCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd _internalSource;

    [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd InternalSource {
        get => _internalSource;
        set {
            InternalSourceSpecified = true;
            _internalSource = value;
        }
    }

    [XmlIgnore]
    public bool InternalSourceSpecified { get; set; }
}
}
