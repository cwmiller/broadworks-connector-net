using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInterceptGroupModifyRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

    [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection {
        get => _announcementSelection;
        set {
            AnnouncementSelectionSpecified = true;
            _announcementSelection = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.InterceptInboundCall _inboundCallMode;

    [XmlElement(ElementName = "inboundCallMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.InterceptInboundCall InboundCallMode {
        get => _inboundCallMode;
        set {
            InboundCallModeSpecified = true;
            _inboundCallMode = value;
        }
    }

    [XmlIgnore]
    public bool InboundCallModeSpecified { get; set; }
    private bool _alternateBlockingAnnouncement;

    [XmlElement(ElementName = "alternateBlockingAnnouncement", IsNullable = false, Namespace = "")]
    public bool AlternateBlockingAnnouncement {
        get => _alternateBlockingAnnouncement;
        set {
            AlternateBlockingAnnouncementSpecified = true;
            _alternateBlockingAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool AlternateBlockingAnnouncementSpecified { get; set; }
    private bool _exemptInboundMobilityCalls;

    [XmlElement(ElementName = "exemptInboundMobilityCalls", IsNullable = false, Namespace = "")]
    public bool ExemptInboundMobilityCalls {
        get => _exemptInboundMobilityCalls;
        set {
            ExemptInboundMobilityCallsSpecified = true;
            _exemptInboundMobilityCalls = value;
        }
    }

    [XmlIgnore]
    public bool ExemptInboundMobilityCallsSpecified { get; set; }
    private bool _disableParallelRingingToNetworkLocations;

    [XmlElement(ElementName = "disableParallelRingingToNetworkLocations", IsNullable = false, Namespace = "")]
    public bool DisableParallelRingingToNetworkLocations {
        get => _disableParallelRingingToNetworkLocations;
        set {
            DisableParallelRingingToNetworkLocationsSpecified = true;
            _disableParallelRingingToNetworkLocations = value;
        }
    }

    [XmlIgnore]
    public bool DisableParallelRingingToNetworkLocationsSpecified { get; set; }
    private bool _routeToVoiceMail;

    [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false, Namespace = "")]
    public bool RouteToVoiceMail {
        get => _routeToVoiceMail;
        set {
            RouteToVoiceMailSpecified = true;
            _routeToVoiceMail = value;
        }
    }

    [XmlIgnore]
    public bool RouteToVoiceMailSpecified { get; set; }
    private bool _playNewPhoneNumber;

    [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false, Namespace = "")]
    public bool PlayNewPhoneNumber {
        get => _playNewPhoneNumber;
        set {
            PlayNewPhoneNumberSpecified = true;
            _playNewPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PlayNewPhoneNumberSpecified { get; set; }
    private string _newPhoneNumber;

    [XmlElement(ElementName = "newPhoneNumber", IsNullable = true, Namespace = "")]
    public string NewPhoneNumber {
        get => _newPhoneNumber;
        set {
            NewPhoneNumberSpecified = true;
            _newPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool NewPhoneNumberSpecified { get; set; }
    private bool _transferOnZeroToPhoneNumber;

    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
    public bool TransferOnZeroToPhoneNumber {
        get => _transferOnZeroToPhoneNumber;
        set {
            TransferOnZeroToPhoneNumberSpecified = true;
            _transferOnZeroToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferOnZeroToPhoneNumberSpecified { get; set; }
    private string _transferPhoneNumber;

    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
    public string TransferPhoneNumber {
        get => _transferPhoneNumber;
        set {
            TransferPhoneNumberSpecified = true;
            _transferPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferPhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.InterceptOutboundCall _outboundCallMode;

    [XmlElement(ElementName = "outboundCallMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.InterceptOutboundCall OutboundCallMode {
        get => _outboundCallMode;
        set {
            OutboundCallModeSpecified = true;
            _outboundCallMode = value;
        }
    }

    [XmlIgnore]
    public bool OutboundCallModeSpecified { get; set; }
    private bool _exemptOutboundMobilityCalls;

    [XmlElement(ElementName = "exemptOutboundMobilityCalls", IsNullable = false, Namespace = "")]
    public bool ExemptOutboundMobilityCalls {
        get => _exemptOutboundMobilityCalls;
        set {
            ExemptOutboundMobilityCallsSpecified = true;
            _exemptOutboundMobilityCalls = value;
        }
    }

    [XmlIgnore]
    public bool ExemptOutboundMobilityCallsSpecified { get; set; }
    private bool _rerouteOutboundCalls;

    [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false, Namespace = "")]
    public bool RerouteOutboundCalls {
        get => _rerouteOutboundCalls;
        set {
            RerouteOutboundCallsSpecified = true;
            _rerouteOutboundCalls = value;
        }
    }

    [XmlIgnore]
    public bool RerouteOutboundCallsSpecified { get; set; }
    private string _outboundReroutePhoneNumber;

    [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = true, Namespace = "")]
    public string OutboundReroutePhoneNumber {
        get => _outboundReroutePhoneNumber;
        set {
            OutboundReroutePhoneNumberSpecified = true;
            _outboundReroutePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool OutboundReroutePhoneNumberSpecified { get; set; }
}
}
