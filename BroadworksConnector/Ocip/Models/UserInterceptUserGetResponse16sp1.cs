using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserInterceptUserGetRequest16sp1.
    /// 
    /// Replaced by: UserInterceptUserGetResponse21sp1 in AS data mode
        /// <see cref="UserInterceptUserGetRequest16sp1"/>
        /// <see cref="UserInterceptUserGetResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserInterceptUserGetResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection {
            get => _announcementSelection;
            set {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementSelectionSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType {
            get => _audioMediaType;
            set {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        public bool AudioMediaTypeSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType {
            get => _videoMediaType;
            set {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        public bool VideoMediaTypeSpecified { get; set; }
        
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

        [XmlElement(ElementName = "newPhoneNumber", IsNullable = false, Namespace = "")]
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

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        public string TransferPhoneNumber {
            get => _transferPhoneNumber;
            set {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferPhoneNumberSpecified { get; set; }
        
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

        [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = false, Namespace = "")]
        public string OutboundReroutePhoneNumber {
            get => _outboundReroutePhoneNumber;
            set {
                OutboundReroutePhoneNumberSpecified = true;
                _outboundReroutePhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool OutboundReroutePhoneNumberSpecified { get; set; }
        
        private bool _allowOutboundLocalCalls;

        [XmlElement(ElementName = "allowOutboundLocalCalls", IsNullable = false, Namespace = "")]
        public bool AllowOutboundLocalCalls {
            get => _allowOutboundLocalCalls;
            set {
                AllowOutboundLocalCallsSpecified = true;
                _allowOutboundLocalCalls = value;
            }
        }

        [XmlIgnore]
        public bool AllowOutboundLocalCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.InterceptInboundCall _inboundCallMode;

        [XmlElement(ElementName = "inboundCallMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.InterceptInboundCall InboundCallMode {
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
        
    }
}
