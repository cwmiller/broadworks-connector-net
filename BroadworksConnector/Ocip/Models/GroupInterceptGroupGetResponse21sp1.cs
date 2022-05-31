using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupInterceptGroupGetRequest21sp1.
    /// 
    /// The following elements are only used in AS data mode:
    /// exemptInboundMobilityCalls
    /// exemptOutboundMobilityCalls
    /// disableParallelRingingToNetworkLocations
    /// <see cref="GroupInterceptGroupGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:70""}]")]
    public class GroupInterceptGroupGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection
        {
            get => _announcementSelection;
            set
            {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementSelectionSpecified { get; set; }

        protected string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileDescription
        {
            get => _audioFileDescription;
            set
            {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType
        {
            get => _audioMediaType;
            set
            {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMediaTypeSpecified { get; set; }

        protected string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileDescription
        {
            get => _videoFileDescription;
            set
            {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType
        {
            get => _videoMediaType;
            set
            {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMediaTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.InterceptInboundCall _inboundCallMode;

        [XmlElement(ElementName = "inboundCallMode", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public BroadWorksConnector.Ocip.Models.InterceptInboundCall InboundCallMode
        {
            get => _inboundCallMode;
            set
            {
                InboundCallModeSpecified = true;
                _inboundCallMode = value;
            }
        }

        [XmlIgnore]
        protected bool InboundCallModeSpecified { get; set; }

        protected bool _alternateBlockingAnnouncement;

        [XmlElement(ElementName = "alternateBlockingAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool AlternateBlockingAnnouncement
        {
            get => _alternateBlockingAnnouncement;
            set
            {
                AlternateBlockingAnnouncementSpecified = true;
                _alternateBlockingAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateBlockingAnnouncementSpecified { get; set; }

        protected bool _exemptInboundMobilityCalls;

        [XmlElement(ElementName = "exemptInboundMobilityCalls", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool ExemptInboundMobilityCalls
        {
            get => _exemptInboundMobilityCalls;
            set
            {
                ExemptInboundMobilityCallsSpecified = true;
                _exemptInboundMobilityCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ExemptInboundMobilityCallsSpecified { get; set; }

        protected bool _disableParallelRingingToNetworkLocations;

        [XmlElement(ElementName = "disableParallelRingingToNetworkLocations", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool DisableParallelRingingToNetworkLocations
        {
            get => _disableParallelRingingToNetworkLocations;
            set
            {
                DisableParallelRingingToNetworkLocationsSpecified = true;
                _disableParallelRingingToNetworkLocations = value;
            }
        }

        [XmlIgnore]
        protected bool DisableParallelRingingToNetworkLocationsSpecified { get; set; }

        protected bool _routeToVoiceMail;

        [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool RouteToVoiceMail
        {
            get => _routeToVoiceMail;
            set
            {
                RouteToVoiceMailSpecified = true;
                _routeToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool RouteToVoiceMailSpecified { get; set; }

        protected bool _playNewPhoneNumber;

        [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool PlayNewPhoneNumber
        {
            get => _playNewPhoneNumber;
            set
            {
                PlayNewPhoneNumberSpecified = true;
                _playNewPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PlayNewPhoneNumberSpecified { get; set; }

        protected string _newPhoneNumber;

        [XmlElement(ElementName = "newPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        [MinLength(1)]
        [MaxLength(23)]
        public string NewPhoneNumber
        {
            get => _newPhoneNumber;
            set
            {
                NewPhoneNumberSpecified = true;
                _newPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool NewPhoneNumberSpecified { get; set; }

        protected bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool TransferOnZeroToPhoneNumber
        {
            get => _transferOnZeroToPhoneNumber;
            set
            {
                TransferOnZeroToPhoneNumberSpecified = true;
                _transferOnZeroToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        protected string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferPhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.InterceptOutboundCall _outboundCallMode;

        [XmlElement(ElementName = "outboundCallMode", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public BroadWorksConnector.Ocip.Models.InterceptOutboundCall OutboundCallMode
        {
            get => _outboundCallMode;
            set
            {
                OutboundCallModeSpecified = true;
                _outboundCallMode = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundCallModeSpecified { get; set; }

        protected bool _exemptOutboundMobilityCalls;

        [XmlElement(ElementName = "exemptOutboundMobilityCalls", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool ExemptOutboundMobilityCalls
        {
            get => _exemptOutboundMobilityCalls;
            set
            {
                ExemptOutboundMobilityCallsSpecified = true;
                _exemptOutboundMobilityCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ExemptOutboundMobilityCallsSpecified { get; set; }

        protected bool _rerouteOutboundCalls;

        [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        public bool RerouteOutboundCalls
        {
            get => _rerouteOutboundCalls;
            set
            {
                RerouteOutboundCallsSpecified = true;
                _rerouteOutboundCalls = value;
            }
        }

        [XmlIgnore]
        protected bool RerouteOutboundCallsSpecified { get; set; }

        protected string _outboundReroutePhoneNumber;

        [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:70")]
        [MinLength(1)]
        [MaxLength(161)]
        public string OutboundReroutePhoneNumber
        {
            get => _outboundReroutePhoneNumber;
            set
            {
                OutboundReroutePhoneNumberSpecified = true;
                _outboundReroutePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundReroutePhoneNumberSpecified { get; set; }

    }
}
