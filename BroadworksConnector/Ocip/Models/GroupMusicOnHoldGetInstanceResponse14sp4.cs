using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetInstanceResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSelection;

    [XmlElement(ElementName = "messageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSelection {
        get => _messageSelection;
        set {
            MessageSelectionSpecified = true;
            _messageSelection = value;
        }
    }

    [XmlIgnore]
    public bool MessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
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
    private string _audioFileDescription;

    [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
    public string AudioFileDescription {
        get => _audioFileDescription;
        set {
            AudioFileDescriptionSpecified = true;
            _audioFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileDescriptionSpecified { get; set; }
    private string _videoFileDescription;

    [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
    public string VideoFileDescription {
        get => _videoFileDescription;
        set {
            VideoFileDescriptionSpecified = true;
            _videoFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileDescriptionSpecified { get; set; }
}
}
