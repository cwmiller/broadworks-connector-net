using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldAddInstanceRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSelection;

    [XmlElement(ElementName = "messageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSelection {
        get => _messageSelection;
        set {
            MessageSelectionSpecified = true;
            _messageSelection = value;
        }
    }

    [XmlIgnore]
    public bool MessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointAdd _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointAdd AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledFileResource VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
}
}
