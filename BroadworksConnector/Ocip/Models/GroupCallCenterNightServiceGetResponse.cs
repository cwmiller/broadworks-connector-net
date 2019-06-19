using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterNightServiceGetRequest.
    /// <see cref="GroupCallCenterNightServiceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:13034""}]")]
    public class GroupCallCenterNightServiceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool ActionSpecified { get; set; }

        private string _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool BusinessHoursSpecified { get; set; }

        private bool _forceNightService;

        [XmlElement(ElementName = "forceNightService", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool ForceNightServiceSpecified { get; set; }

        private bool _allowManualOverrideViaFAC;

        [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool AllowManualOverrideViaFACSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool TransferPhoneNumberSpecified { get; set; }

        private bool _playAnnouncementBeforeAction;

        [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool PlayAnnouncementBeforeActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool AudioMessageSelectionSpecified { get; set; }

        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileUrl
        {
            get => _audioFileUrl;
            set
            {
                AudioFileUrlSpecified = true;
                _audioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileUrlSpecified { get; set; }

        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool AudioFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool AudioMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool VideoMessageSelectionSpecified { get; set; }

        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileUrl
        {
            get => _videoFileUrl;
            set
            {
                VideoFileUrlSpecified = true;
                _videoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileUrlSpecified { get; set; }

        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool VideoFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool VideoMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

        [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool ManualAnnouncementModeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualAudioMessageSelection;

        [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool ManualAudioMessageSelectionSpecified { get; set; }

        private string _manualAudioFileUrl;

        [XmlElement(ElementName = "manualAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ManualAudioFileUrl
        {
            get => _manualAudioFileUrl;
            set
            {
                ManualAudioFileUrlSpecified = true;
                _manualAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool ManualAudioFileUrlSpecified { get; set; }

        private string _manualAudioFileDescription;

        [XmlElement(ElementName = "manualAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ManualAudioFileDescription
        {
            get => _manualAudioFileDescription;
            set
            {
                ManualAudioFileDescriptionSpecified = true;
                _manualAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool ManualAudioFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _manualAudioMediaType;

        [XmlElement(ElementName = "manualAudioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        public BroadWorksConnector.Ocip.Models.MediaFileType ManualAudioMediaType
        {
            get => _manualAudioMediaType;
            set
            {
                ManualAudioMediaTypeSpecified = true;
                _manualAudioMediaType = value;
            }
        }

        [XmlIgnore]
        public bool ManualAudioMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

        [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
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
        public bool ManualVideoMessageSelectionSpecified { get; set; }

        private string _manualVideoFileUrl;

        [XmlElement(ElementName = "manualVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ManualVideoFileUrl
        {
            get => _manualVideoFileUrl;
            set
            {
                ManualVideoFileUrlSpecified = true;
                _manualVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool ManualVideoFileUrlSpecified { get; set; }

        private string _manualVideoFileDescription;

        [XmlElement(ElementName = "manualVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ManualVideoFileDescription
        {
            get => _manualVideoFileDescription;
            set
            {
                ManualVideoFileDescriptionSpecified = true;
                _manualVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool ManualVideoFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _manualVideoMediaType;

        [XmlElement(ElementName = "manualVideoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13034")]
        public BroadWorksConnector.Ocip.Models.MediaFileType ManualVideoMediaType
        {
            get => _manualVideoMediaType;
            set
            {
                ManualVideoMediaTypeSpecified = true;
                _manualVideoMediaType = value;
            }
        }

        [XmlIgnore]
        public bool ManualVideoMediaTypeSpecified { get; set; }

    }
}
