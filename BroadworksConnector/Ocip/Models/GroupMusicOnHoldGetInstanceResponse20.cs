using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetInstanceResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _enableVideo;

    [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
    public bool EnableVideo {
        get => _enableVideo;
        set {
            EnableVideoSpecified = true;
            _enableVideo = value;
        }
    }

    [XmlIgnore]
    public bool EnableVideoSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20 _source;

    [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20 Source {
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
    private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20 _internalSource;

    [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20 InternalSource {
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
