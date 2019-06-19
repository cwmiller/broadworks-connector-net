using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointNightServiceGetRequest.
    /// <see cref="GroupRoutePointNightServiceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20075""}]")]
    public class GroupRoutePointNightServiceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool AudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool AudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _audioMediaTypeList;

        [XmlElement(ElementName = "audioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool AudioMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool VideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool VideoFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _videoMediaTypeList;

        [XmlElement(ElementName = "videoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool VideoMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

        [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _manualAudioUrlList;

        [XmlElement(ElementName = "manualAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualAudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _manualAudioFileList;

        [XmlElement(ElementName = "manualAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualAudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _manualAudioMediaTypeList;

        [XmlElement(ElementName = "manualAudioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualAudioMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

        [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _manualVideoUrlList;

        [XmlElement(ElementName = "manualVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualVideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _manualVideoFileList;

        [XmlElement(ElementName = "manualVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualVideoFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _manualVideoMediaTypeList;

        [XmlElement(ElementName = "manualVideoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20075")]
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
        public bool ManualVideoMediaTypeListSpecified { get; set; }

    }
}
