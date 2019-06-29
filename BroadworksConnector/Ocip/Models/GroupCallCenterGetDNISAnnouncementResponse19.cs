using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDNISAnnouncementRequest19.
    /// <see cref="GroupCallCenterGetDNISAnnouncementRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:29519""}]")]
    public class GroupCallCenterGetDNISAnnouncementResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public bool PlayEntranceMessage
        {
            get => _playEntranceMessage;
            set
            {
                PlayEntranceMessageSpecified = true;
                _playEntranceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEntranceMessageSpecified { get; set; }

        private bool _mandatoryEntranceMessage;

        [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public bool MandatoryEntranceMessage
        {
            get => _mandatoryEntranceMessage;
            set
            {
                MandatoryEntranceMessageSpecified = true;
                _mandatoryEntranceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool MandatoryEntranceMessageSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceAudioMessageSelection;

        [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection
        {
            get => _entranceAudioMessageSelection;
            set
            {
                EntranceAudioMessageSelectionSpecified = true;
                _entranceAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceAudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageAudioUrlList;

        [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageAudioUrlList
        {
            get => _entranceMessageAudioUrlList;
            set
            {
                EntranceMessageAudioUrlListSpecified = true;
                _entranceMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _entranceMessageAudioFileList;

        [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList EntranceMessageAudioFileList
        {
            get => _entranceMessageAudioFileList;
            set
            {
                EntranceMessageAudioFileListSpecified = true;
                _entranceMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _entranceMessageAudioMediaTypeList;

        [XmlElement(ElementName = "entranceMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList EntranceMessageAudioMediaTypeList
        {
            get => _entranceMessageAudioMediaTypeList;
            set
            {
                EntranceMessageAudioMediaTypeListSpecified = true;
                _entranceMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection
        {
            get => _entranceVideoMessageSelection;
            set
            {
                EntranceVideoMessageSelectionSpecified = true;
                _entranceVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceVideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageVideoUrlList;

        [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageVideoUrlList
        {
            get => _entranceMessageVideoUrlList;
            set
            {
                EntranceMessageVideoUrlListSpecified = true;
                _entranceMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _entranceMessageVideoFileList;

        [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList EntranceMessageVideoFileList
        {
            get => _entranceMessageVideoFileList;
            set
            {
                EntranceMessageVideoFileListSpecified = true;
                _entranceMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _entranceMessageVideoMediaTypeList;

        [XmlElement(ElementName = "entranceMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList EntranceMessageVideoMediaTypeList
        {
            get => _entranceMessageVideoMediaTypeList;
            set
            {
                EntranceMessageVideoMediaTypeListSpecified = true;
                _entranceMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoMediaTypeListSpecified { get; set; }

        private bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public bool PlayPeriodicComfortMessage
        {
            get => _playPeriodicComfortMessage;
            set
            {
                PlayPeriodicComfortMessageSpecified = true;
                _playPeriodicComfortMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayPeriodicComfortMessageSpecified { get; set; }

        private int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        [MinInclusive(10)]
        [MaxInclusive(600)]
        public int TimeBetweenComfortMessagesSeconds
        {
            get => _timeBetweenComfortMessagesSeconds;
            set
            {
                TimeBetweenComfortMessagesSecondsSpecified = true;
                _timeBetweenComfortMessagesSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortAudioMessageSelection;

        [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection
        {
            get => _periodicComfortAudioMessageSelection;
            set
            {
                PeriodicComfortAudioMessageSelectionSpecified = true;
                _periodicComfortAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortAudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageAudioUrlList;

        [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageAudioUrlList
        {
            get => _periodicComfortMessageAudioUrlList;
            set
            {
                PeriodicComfortMessageAudioUrlListSpecified = true;
                _periodicComfortMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _periodicComfortMessageAudioFileList;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList PeriodicComfortMessageAudioFileList
        {
            get => _periodicComfortMessageAudioFileList;
            set
            {
                PeriodicComfortMessageAudioFileListSpecified = true;
                _periodicComfortMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _periodicComfortMessageAudioMediaTypeList;

        [XmlElement(ElementName = "periodicComfortMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList PeriodicComfortMessageAudioMediaTypeList
        {
            get => _periodicComfortMessageAudioMediaTypeList;
            set
            {
                PeriodicComfortMessageAudioMediaTypeListSpecified = true;
                _periodicComfortMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection
        {
            get => _periodicComfortVideoMessageSelection;
            set
            {
                PeriodicComfortVideoMessageSelectionSpecified = true;
                _periodicComfortVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortVideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageVideoUrlList;

        [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageVideoUrlList
        {
            get => _periodicComfortMessageVideoUrlList;
            set
            {
                PeriodicComfortMessageVideoUrlListSpecified = true;
                _periodicComfortMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _periodicComfortMessageVideoFileList;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList PeriodicComfortMessageVideoFileList
        {
            get => _periodicComfortMessageVideoFileList;
            set
            {
                PeriodicComfortMessageVideoFileListSpecified = true;
                _periodicComfortMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _periodicComfortMessageVideoMediaTypeList;

        [XmlElement(ElementName = "periodicComfortMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList PeriodicComfortMessageVideoMediaTypeList
        {
            get => _periodicComfortMessageVideoMediaTypeList;
            set
            {
                PeriodicComfortMessageVideoMediaTypeListSpecified = true;
                _periodicComfortMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoMediaTypeListSpecified { get; set; }

        private bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public bool EnableMediaOnHoldForQueuedCalls
        {
            get => _enableMediaOnHoldForQueuedCalls;
            set
            {
                EnableMediaOnHoldForQueuedCallsSpecified = true;
                _enableMediaOnHoldForQueuedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMediaOnHoldForQueuedCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 MediaOnHoldSource
        {
            get => _mediaOnHoldSource;
            set
            {
                MediaOnHoldSourceSpecified = true;
                _mediaOnHoldSource = value;
            }
        }

        [XmlIgnore]
        protected bool MediaOnHoldSourceSpecified { get; set; }

        private bool _playWhisperMessage;

        [XmlElement(ElementName = "playWhisperMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public bool PlayWhisperMessage
        {
            get => _playWhisperMessage;
            set
            {
                PlayWhisperMessageSpecified = true;
                _playWhisperMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayWhisperMessageSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperAudioMessageSelection;

        [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperAudioMessageSelection
        {
            get => _whisperAudioMessageSelection;
            set
            {
                WhisperAudioMessageSelectionSpecified = true;
                _whisperAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperAudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageAudioUrlList;

        [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageAudioUrlList
        {
            get => _whisperMessageAudioUrlList;
            set
            {
                WhisperMessageAudioUrlListSpecified = true;
                _whisperMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageAudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _whisperMessageAudioFileList;

        [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList WhisperMessageAudioFileList
        {
            get => _whisperMessageAudioFileList;
            set
            {
                WhisperMessageAudioFileListSpecified = true;
                _whisperMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageAudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _whisperMessageAudioMediaTypeList;

        [XmlElement(ElementName = "whisperMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList WhisperMessageAudioMediaTypeList
        {
            get => _whisperMessageAudioMediaTypeList;
            set
            {
                WhisperMessageAudioMediaTypeListSpecified = true;
                _whisperMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageAudioMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperVideoMessageSelection;

        [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperVideoMessageSelection
        {
            get => _whisperVideoMessageSelection;
            set
            {
                WhisperVideoMessageSelectionSpecified = true;
                _whisperVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperVideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageVideoUrlList;

        [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageVideoUrlList
        {
            get => _whisperMessageVideoUrlList;
            set
            {
                WhisperMessageVideoUrlListSpecified = true;
                _whisperMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageVideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _whisperMessageVideoFileList;

        [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList WhisperMessageVideoFileList
        {
            get => _whisperMessageVideoFileList;
            set
            {
                WhisperMessageVideoFileListSpecified = true;
                _whisperMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageVideoFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _whisperMessageVideoMediaTypeList;

        [XmlElement(ElementName = "whisperMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList WhisperMessageVideoMediaTypeList
        {
            get => _whisperMessageVideoMediaTypeList;
            set
            {
                WhisperMessageVideoMediaTypeListSpecified = true;
                _whisperMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageVideoMediaTypeListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 _estimatedWaitMessageOptionsRead;

        [XmlElement(ElementName = "estimatedWaitMessageOptionsRead", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29519")]
        public BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 EstimatedWaitMessageOptionsRead
        {
            get => _estimatedWaitMessageOptionsRead;
            set
            {
                EstimatedWaitMessageOptionsReadSpecified = true;
                _estimatedWaitMessageOptionsRead = value;
            }
        }

        [XmlIgnore]
        protected bool EstimatedWaitMessageOptionsReadSpecified { get; set; }

    }
}
