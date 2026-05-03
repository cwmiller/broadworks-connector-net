using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallRecordingGetRequest23.
    /// The response contains the user's Call Recording option information.
    /// The following parameters are not returned for service instance:
    /// - pauseResumeNotification
    /// - enableCallRecordingAnnouncement
    /// - enableRecordCallRepeatWarningTone
    /// - recordCallRepeatWarningToneTimerSeconds
    /// The enableVoiceMailRecording parameter is only returned if the Voice
    /// Messaging User service is assigned to the user.  This applies to both
    /// users and service instances.
    /// The recordingOption and enableCallRecordingAnnouncement which elements can
    /// only be modified by a System or a Provisioning administrator when
    /// restrictCallRecordingProvisioningAccess system param is set to true. Both the element
    /// values will be ignored when group admin or lower runs this.
    /// The following elements are not returned in AS and XS data mode:
    /// mediaStream
    /// 
    /// Replaced by: UserCallRecordingGetResponseRI.
    /// <see cref="UserCallRecordingGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:19566""}]")]
    public class UserCallRecordingGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.RecordingOption20 _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public BroadWorksConnector.Ocip.Models.RecordingOption20 RecordingOption
        {
            get => _recordingOption;
            set
            {
                RecordingOptionSpecified = true;
                _recordingOption = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingOptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType? _pauseResumeNotification;

        [XmlElement(ElementName = "pauseResumeNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType? PauseResumeNotification
        {
            get => _pauseResumeNotification;
            set
            {
                PauseResumeNotificationSpecified = (value != null);
                _pauseResumeNotification = value;
            }
        }

        [XmlIgnore]
        protected bool PauseResumeNotificationSpecified { get; set; }

        protected bool? _enableCallRecordingAnnouncement;

        [XmlElement(ElementName = "enableCallRecordingAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public bool? EnableCallRecordingAnnouncement
        {
            get => _enableCallRecordingAnnouncement;
            set
            {
                EnableCallRecordingAnnouncementSpecified = (value != null);
                _enableCallRecordingAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallRecordingAnnouncementSpecified { get; set; }

        protected bool? _enableRecordCallRepeatWarningTone;

        [XmlElement(ElementName = "enableRecordCallRepeatWarningTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public bool? EnableRecordCallRepeatWarningTone
        {
            get => _enableRecordCallRepeatWarningTone;
            set
            {
                EnableRecordCallRepeatWarningToneSpecified = (value != null);
                _enableRecordCallRepeatWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRecordCallRepeatWarningToneSpecified { get; set; }

        protected int? _recordCallRepeatWarningToneTimerSeconds;

        [XmlElement(ElementName = "recordCallRepeatWarningToneTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        [MinInclusive(10)]
        [MaxInclusive(1800)]
        public int? RecordCallRepeatWarningToneTimerSeconds
        {
            get => _recordCallRepeatWarningToneTimerSeconds;
            set
            {
                RecordCallRepeatWarningToneTimerSecondsSpecified = (value != null);
                _recordCallRepeatWarningToneTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RecordCallRepeatWarningToneTimerSecondsSpecified { get; set; }

        protected bool? _enableVoiceMailRecording;

        [XmlElement(ElementName = "enableVoiceMailRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public bool? EnableVoiceMailRecording
        {
            get => _enableVoiceMailRecording;
            set
            {
                EnableVoiceMailRecordingSpecified = (value != null);
                _enableVoiceMailRecording = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVoiceMailRecordingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaStream? _mediaStream;

        [XmlElement(ElementName = "mediaStream", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19566")]
        public BroadWorksConnector.Ocip.Models.MediaStream? MediaStream
        {
            get => _mediaStream;
            set
            {
                MediaStreamSpecified = (value != null);
                _mediaStream = value;
            }
        }

        [XmlIgnore]
        protected bool MediaStreamSpecified { get; set; }

    }
}
