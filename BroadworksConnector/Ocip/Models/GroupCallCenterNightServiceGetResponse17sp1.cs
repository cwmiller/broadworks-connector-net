using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterNightServiceGetRequest17sp1.
    /// <see cref="GroupCallCenterNightServiceGetRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9bff48d8661ff401ea11b6e32b924f02:122""}]")]
    public class GroupCallCenterNightServiceGetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule BusinessHours
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

        protected bool _forceNightService;

        [XmlElement(ElementName = "forceNightService", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected bool _allowManualOverrideViaFAC;

        [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected bool _playAnnouncementBeforeAction;

        [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _audioMediaTypeList;

        [XmlElement(ElementName = "audioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList AudioMediaTypeList
        {
            get => _audioMediaTypeList;
            set
            {
                AudioMediaTypeListSpecified = true;
                _audioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMediaTypeListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _videoMediaTypeList;

        [XmlElement(ElementName = "videoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList VideoMediaTypeList
        {
            get => _videoMediaTypeList;
            set
            {
                VideoMediaTypeListSpecified = true;
                _videoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMediaTypeListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

        [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualAudioMessageSelection;

        [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _manualAudioUrlList;

        [XmlElement(ElementName = "manualAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList ManualAudioUrlList
        {
            get => _manualAudioUrlList;
            set
            {
                ManualAudioUrlListSpecified = true;
                _manualAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _manualAudioFileList;

        [XmlElement(ElementName = "manualAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList ManualAudioFileList
        {
            get => _manualAudioFileList;
            set
            {
                ManualAudioFileListSpecified = true;
                _manualAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _manualAudioMediaTypeList;

        [XmlElement(ElementName = "manualAudioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList ManualAudioMediaTypeList
        {
            get => _manualAudioMediaTypeList;
            set
            {
                ManualAudioMediaTypeListSpecified = true;
                _manualAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualAudioMediaTypeListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

        [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _manualVideoUrlList;

        [XmlElement(ElementName = "manualVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList ManualVideoUrlList
        {
            get => _manualVideoUrlList;
            set
            {
                ManualVideoUrlListSpecified = true;
                _manualVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualVideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _manualVideoFileList;

        [XmlElement(ElementName = "manualVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList ManualVideoFileList
        {
            get => _manualVideoFileList;
            set
            {
                ManualVideoFileListSpecified = true;
                _manualVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualVideoFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _manualVideoMediaTypeList;

        [XmlElement(ElementName = "manualVideoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:122")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList ManualVideoMediaTypeList
        {
            get => _manualVideoMediaTypeList;
            set
            {
                ManualVideoMediaTypeListSpecified = true;
                _manualVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool ManualVideoMediaTypeListSpecified { get; set; }

    }
}
