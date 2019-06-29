using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's intercept user service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// exemptInboundMobilityCalls
    /// exemptOutboundMobilityCalls
    /// disableParallelRingingToNetworkLocations
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:327""}]")]
    public class UserInterceptUserModifyRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.InterceptInboundCall _inboundCallMode;

        [XmlElement(ElementName = "inboundCallMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _alternateBlockingAnnouncement;

        [XmlElement(ElementName = "alternateBlockingAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _exemptInboundMobilityCalls;

        [XmlElement(ElementName = "exemptInboundMobilityCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _disableParallelRingingToNetworkLocations;

        [XmlElement(ElementName = "disableParallelRingingToNetworkLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _routeToVoiceMail;

        [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _playNewPhoneNumber;

        [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private string _newPhoneNumber;

        [XmlElement(ElementName = "newPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private BroadWorksConnector.Ocip.Models.InterceptOutboundCall _outboundCallMode;

        [XmlElement(ElementName = "outboundCallMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _exemptOutboundMobilityCalls;

        [XmlElement(ElementName = "exemptOutboundMobilityCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private bool _rerouteOutboundCalls;

        [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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

        private string _outboundReroutePhoneNumber;

        [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:327")]
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
