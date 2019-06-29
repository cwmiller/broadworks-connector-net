using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Call Recording attributes for a user. The recording options
    /// "Always with Pause/Resume", "On Demand", and "On Demand with User
    /// Initiated Start" are not accepted for service instances.
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following parameters are not accepted for service
    /// instance:
    /// - pauseResumeNotification
    /// - enableCallRecordingAnnouncement
    /// - enableRecordCallRepeatWarningTone
    /// - recordCallRepeatWarningToneTimerSeconds
    /// 
    /// The enableVoiceMailRecording parameter is only applicable
    /// if the Voice Messaging User service is assigned to the user.
    /// This applies to both users and service instances.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:457""}]")]
    public class UserCallRecordingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
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

        private BroadWorksConnector.Ocip.Models.RecordingOption20 _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
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

        private BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType _pauseResumeNotification;

        [XmlElement(ElementName = "pauseResumeNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
        public BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType PauseResumeNotification
        {
            get => _pauseResumeNotification;
            set
            {
                PauseResumeNotificationSpecified = true;
                _pauseResumeNotification = value;
            }
        }

        [XmlIgnore]
        protected bool PauseResumeNotificationSpecified { get; set; }

        private bool _enableCallRecordingAnnouncement;

        [XmlElement(ElementName = "enableCallRecordingAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
        public bool EnableCallRecordingAnnouncement
        {
            get => _enableCallRecordingAnnouncement;
            set
            {
                EnableCallRecordingAnnouncementSpecified = true;
                _enableCallRecordingAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallRecordingAnnouncementSpecified { get; set; }

        private bool _enableRecordCallRepeatWarningTone;

        [XmlElement(ElementName = "enableRecordCallRepeatWarningTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
        public bool EnableRecordCallRepeatWarningTone
        {
            get => _enableRecordCallRepeatWarningTone;
            set
            {
                EnableRecordCallRepeatWarningToneSpecified = true;
                _enableRecordCallRepeatWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRecordCallRepeatWarningToneSpecified { get; set; }

        private int _recordCallRepeatWarningToneTimerSeconds;

        [XmlElement(ElementName = "recordCallRepeatWarningToneTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
        [MinInclusive(10)]
        [MaxInclusive(1800)]
        public int RecordCallRepeatWarningToneTimerSeconds
        {
            get => _recordCallRepeatWarningToneTimerSeconds;
            set
            {
                RecordCallRepeatWarningToneTimerSecondsSpecified = true;
                _recordCallRepeatWarningToneTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RecordCallRepeatWarningToneTimerSecondsSpecified { get; set; }

        private bool _enableVoiceMailRecording;

        [XmlElement(ElementName = "enableVoiceMailRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:457")]
        public bool EnableVoiceMailRecording
        {
            get => _enableVoiceMailRecording;
            set
            {
                EnableVoiceMailRecordingSpecified = true;
                _enableVoiceMailRecording = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVoiceMailRecordingSpecified { get; set; }

    }
}
