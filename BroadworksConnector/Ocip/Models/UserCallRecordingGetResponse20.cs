using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallRecordingGetRequest20.
    /// The response contains the user's Call Recording option information.
    /// 
    /// The following parameters are not returned for service instance:
    /// - pauseResumeNotification
    /// - enableCallRecordingAnnouncement
    /// - enableRecordCallRepeatWarningTone
    /// - recordCallRepeatWarningToneTimerSeconds
    /// 
    /// The enableVoiceMailRecording parameter is only returned if the Voice
    /// Messaging User service is assigned to the user.  This applies to both
    /// users and service instances.
    /// 
    /// The recordingOption and enableCallRecordingAnnouncement which elements can
    /// only be modified by a System or a Provisioning administrator when
    /// restrictCallRecordingProvisioningAccess system param is set to true. Both the element
    /// values will be ignored when group admin or lower runs this.
        /// <see cref="UserCallRecordingGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallRecordingGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.RecordingOption20 _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RecordingOption20 RecordingOption {
            get => _recordingOption;
            set {
                RecordingOptionSpecified = true;
                _recordingOption = value;
            }
        }

        [XmlIgnore]
        public bool RecordingOptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType _pauseResumeNotification;

        [XmlElement(ElementName = "pauseResumeNotification", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RecordingPauseResumeNotificationType PauseResumeNotification {
            get => _pauseResumeNotification;
            set {
                PauseResumeNotificationSpecified = true;
                _pauseResumeNotification = value;
            }
        }

        [XmlIgnore]
        public bool PauseResumeNotificationSpecified { get; set; }
        
        private bool _enableCallRecordingAnnouncement;

        [XmlElement(ElementName = "enableCallRecordingAnnouncement", IsNullable = false, Namespace = "")]
        public bool EnableCallRecordingAnnouncement {
            get => _enableCallRecordingAnnouncement;
            set {
                EnableCallRecordingAnnouncementSpecified = true;
                _enableCallRecordingAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallRecordingAnnouncementSpecified { get; set; }
        
        private bool _enableRecordCallRepeatWarningTone;

        [XmlElement(ElementName = "enableRecordCallRepeatWarningTone", IsNullable = false, Namespace = "")]
        public bool EnableRecordCallRepeatWarningTone {
            get => _enableRecordCallRepeatWarningTone;
            set {
                EnableRecordCallRepeatWarningToneSpecified = true;
                _enableRecordCallRepeatWarningTone = value;
            }
        }

        [XmlIgnore]
        public bool EnableRecordCallRepeatWarningToneSpecified { get; set; }
        
        private int _recordCallRepeatWarningToneTimerSeconds;

        [XmlElement(ElementName = "recordCallRepeatWarningToneTimerSeconds", IsNullable = false, Namespace = "")]
        public int RecordCallRepeatWarningToneTimerSeconds {
            get => _recordCallRepeatWarningToneTimerSeconds;
            set {
                RecordCallRepeatWarningToneTimerSecondsSpecified = true;
                _recordCallRepeatWarningToneTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RecordCallRepeatWarningToneTimerSecondsSpecified { get; set; }
        
        private bool _enableVoiceMailRecording;

        [XmlElement(ElementName = "enableVoiceMailRecording", IsNullable = false, Namespace = "")]
        public bool EnableVoiceMailRecording {
            get => _enableVoiceMailRecording;
            set {
                EnableVoiceMailRecordingSpecified = true;
                _enableVoiceMailRecording = value;
            }
        }

        [XmlIgnore]
        public bool EnableVoiceMailRecordingSpecified { get; set; }
        
    }
}
