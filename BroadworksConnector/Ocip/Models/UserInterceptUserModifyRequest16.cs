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
    /// Replaced by: UserInterceptUserModifyResponse21sp1 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserInterceptUserModifyResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18335""}]")]
    public class UserInterceptUserModifyRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected bool _playNewPhoneNumber;

        [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        [XmlElement(ElementName = "newPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected bool _rerouteOutboundCalls;

        [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected bool _allowOutboundLocalCalls;

        [XmlElement(ElementName = "allowOutboundLocalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
        public bool AllowOutboundLocalCalls
        {
            get => _allowOutboundLocalCalls;
            set
            {
                AllowOutboundLocalCallsSpecified = true;
                _allowOutboundLocalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowOutboundLocalCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.InterceptInboundCall _inboundCallMode;

        [XmlElement(ElementName = "inboundCallMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

        protected bool _routeToVoiceMail;

        [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18335")]
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

    }
}
