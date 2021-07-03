using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's night service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6939""}]")]
    public class GroupCallCenterNightServiceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        private string _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        [MinLength(1)]
        [MaxLength(40)]
        public string BusinessHours
        {
            get => _businessHours;
            set
            {
                BusinessHoursSpecified = true;
                _businessHours = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursSpecified { get; set; }

        private bool _forceNightService;

        [XmlElement(ElementName = "forceNightService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public bool ForceNightService
        {
            get => _forceNightService;
            set
            {
                ForceNightServiceSpecified = true;
                _forceNightService = value;
            }
        }

        [XmlIgnore]
        protected bool ForceNightServiceSpecified { get; set; }

        private bool _allowManualOverrideViaFAC;

        [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public bool AllowManualOverrideViaFAC
        {
            get => _allowManualOverrideViaFAC;
            set
            {
                AllowManualOverrideViaFACSpecified = true;
                _allowManualOverrideViaFAC = value;
            }
        }

        [XmlIgnore]
        protected bool AllowManualOverrideViaFACSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        [MinLength(1)]
        [MaxLength(161)]
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

        private bool _playAnnouncementBeforeAction;

        [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public bool PlayAnnouncementBeforeAction
        {
            get => _playAnnouncementBeforeAction;
            set
            {
                PlayAnnouncementBeforeActionSpecified = true;
                _playAnnouncementBeforeAction = value;
            }
        }

        [XmlIgnore]
        protected bool PlayAnnouncementBeforeActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile
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

        private BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

        [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode
        {
            get => _manualAnnouncementMode;
            set
            {
                ManualAnnouncementModeSpecified = true;
                _manualAnnouncementMode = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAnnouncementModeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualAudioMessageSelection;

        [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection
        {
            get => _manualAudioMessageSelection;
            set
            {
                ManualAudioMessageSelectionSpecified = true;
                _manualAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _manualAudioFile;

        [XmlElement(ElementName = "manualAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource ManualAudioFile
        {
            get => _manualAudioFile;
            set
            {
                ManualAudioFileSpecified = true;
                _manualAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

        [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection
        {
            get => _manualVideoMessageSelection;
            set
            {
                ManualVideoMessageSelectionSpecified = true;
                _manualVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ManualVideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _manualVideoFile;

        [XmlElement(ElementName = "manualVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6939")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource ManualVideoFile
        {
            get => _manualVideoFile;
            set
            {
                ManualVideoFileSpecified = true;
                _manualVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool ManualVideoFileSpecified { get; set; }

    }
}
