using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterGetAnnouncementResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
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
        public bool PlayEntranceMessageSpecified { get; set; }
        private bool _mandatoryEntranceMessage;

        [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
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
        public bool MandatoryEntranceMessageSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceAudioMessageSelection;

        [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection
        {
            get => _entranceAudioMessageSelection;
            set
            {
                EntranceAudioMessageSelectionSpecified = true;
                _entranceAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool EntranceAudioMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageAudioUrlList;

        [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageAudioUrlList
        {
            get => _entranceMessageAudioUrlList;
            set
            {
                EntranceMessageAudioUrlListSpecified = true;
                _entranceMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageAudioUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _entranceMessageAudioFileList;

        [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList EntranceMessageAudioFileList
        {
            get => _entranceMessageAudioFileList;
            set
            {
                EntranceMessageAudioFileListSpecified = true;
                _entranceMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageAudioFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _entranceMessageAudioMediaTypeList;

        [XmlElement(ElementName = "entranceMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList EntranceMessageAudioMediaTypeList
        {
            get => _entranceMessageAudioMediaTypeList;
            set
            {
                EntranceMessageAudioMediaTypeListSpecified = true;
                _entranceMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageAudioMediaTypeListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection
        {
            get => _entranceVideoMessageSelection;
            set
            {
                EntranceVideoMessageSelectionSpecified = true;
                _entranceVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool EntranceVideoMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageVideoUrlList;

        [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageVideoUrlList
        {
            get => _entranceMessageVideoUrlList;
            set
            {
                EntranceMessageVideoUrlListSpecified = true;
                _entranceMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageVideoUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _entranceMessageVideoFileList;

        [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList EntranceMessageVideoFileList
        {
            get => _entranceMessageVideoFileList;
            set
            {
                EntranceMessageVideoFileListSpecified = true;
                _entranceMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageVideoFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _entranceMessageVideoMediaTypeList;

        [XmlElement(ElementName = "entranceMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList EntranceMessageVideoMediaTypeList
        {
            get => _entranceMessageVideoMediaTypeList;
            set
            {
                EntranceMessageVideoMediaTypeListSpecified = true;
                _entranceMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageVideoMediaTypeListSpecified { get; set; }
        private bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
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
        public bool PlayPeriodicComfortMessageSpecified { get; set; }
        private int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
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
        public bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortAudioMessageSelection;

        [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection
        {
            get => _periodicComfortAudioMessageSelection;
            set
            {
                PeriodicComfortAudioMessageSelectionSpecified = true;
                _periodicComfortAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortAudioMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageAudioUrlList;

        [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageAudioUrlList
        {
            get => _periodicComfortMessageAudioUrlList;
            set
            {
                PeriodicComfortMessageAudioUrlListSpecified = true;
                _periodicComfortMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageAudioUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _periodicComfortMessageAudioFileList;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList PeriodicComfortMessageAudioFileList
        {
            get => _periodicComfortMessageAudioFileList;
            set
            {
                PeriodicComfortMessageAudioFileListSpecified = true;
                _periodicComfortMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageAudioFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _periodicComfortMessageAudioMediaTypeList;

        [XmlElement(ElementName = "periodicComfortMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList PeriodicComfortMessageAudioMediaTypeList
        {
            get => _periodicComfortMessageAudioMediaTypeList;
            set
            {
                PeriodicComfortMessageAudioMediaTypeListSpecified = true;
                _periodicComfortMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageAudioMediaTypeListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection
        {
            get => _periodicComfortVideoMessageSelection;
            set
            {
                PeriodicComfortVideoMessageSelectionSpecified = true;
                _periodicComfortVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortVideoMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageVideoUrlList;

        [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageVideoUrlList
        {
            get => _periodicComfortMessageVideoUrlList;
            set
            {
                PeriodicComfortMessageVideoUrlListSpecified = true;
                _periodicComfortMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageVideoUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _periodicComfortMessageVideoFileList;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList PeriodicComfortMessageVideoFileList
        {
            get => _periodicComfortMessageVideoFileList;
            set
            {
                PeriodicComfortMessageVideoFileListSpecified = true;
                _periodicComfortMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageVideoFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _periodicComfortMessageVideoMediaTypeList;

        [XmlElement(ElementName = "periodicComfortMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList PeriodicComfortMessageVideoMediaTypeList
        {
            get => _periodicComfortMessageVideoMediaTypeList;
            set
            {
                PeriodicComfortMessageVideoMediaTypeListSpecified = true;
                _periodicComfortMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageVideoMediaTypeListSpecified { get; set; }
        private bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
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
        public bool EnableMediaOnHoldForQueuedCallsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 MediaOnHoldSource
        {
            get => _mediaOnHoldSource;
            set
            {
                MediaOnHoldSourceSpecified = true;
                _mediaOnHoldSource = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldSourceSpecified { get; set; }
        private bool _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        public bool MediaOnHoldUseAlternateSourceForInternalCalls
        {
            get => _mediaOnHoldUseAlternateSourceForInternalCalls;
            set
            {
                MediaOnHoldUseAlternateSourceForInternalCallsSpecified = true;
                _mediaOnHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead19 MediaOnHoldInternalSource
        {
            get => _mediaOnHoldInternalSource;
            set
            {
                MediaOnHoldInternalSourceSpecified = true;
                _mediaOnHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldInternalSourceSpecified { get; set; }
        private bool _playWhisperMessage;

        [XmlElement(ElementName = "playWhisperMessage", IsNullable = false, Namespace = "")]
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
        public bool PlayWhisperMessageSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperAudioMessageSelection;

        [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperAudioMessageSelection
        {
            get => _whisperAudioMessageSelection;
            set
            {
                WhisperAudioMessageSelectionSpecified = true;
                _whisperAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool WhisperAudioMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageAudioUrlList;

        [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageAudioUrlList
        {
            get => _whisperMessageAudioUrlList;
            set
            {
                WhisperMessageAudioUrlListSpecified = true;
                _whisperMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageAudioUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _whisperMessageAudioFileList;

        [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList WhisperMessageAudioFileList
        {
            get => _whisperMessageAudioFileList;
            set
            {
                WhisperMessageAudioFileListSpecified = true;
                _whisperMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageAudioFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _whisperMessageAudioMediaTypeList;

        [XmlElement(ElementName = "whisperMessageAudioMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList WhisperMessageAudioMediaTypeList
        {
            get => _whisperMessageAudioMediaTypeList;
            set
            {
                WhisperMessageAudioMediaTypeListSpecified = true;
                _whisperMessageAudioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageAudioMediaTypeListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperVideoMessageSelection;

        [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperVideoMessageSelection
        {
            get => _whisperVideoMessageSelection;
            set
            {
                WhisperVideoMessageSelectionSpecified = true;
                _whisperVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool WhisperVideoMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageVideoUrlList;

        [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageVideoUrlList
        {
            get => _whisperMessageVideoUrlList;
            set
            {
                WhisperMessageVideoUrlListSpecified = true;
                _whisperMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageVideoUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _whisperMessageVideoFileList;

        [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList WhisperMessageVideoFileList
        {
            get => _whisperMessageVideoFileList;
            set
            {
                WhisperMessageVideoFileListSpecified = true;
                _whisperMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageVideoFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _whisperMessageVideoMediaTypeList;

        [XmlElement(ElementName = "whisperMessageVideoMediaTypeList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList WhisperMessageVideoMediaTypeList
        {
            get => _whisperMessageVideoMediaTypeList;
            set
            {
                WhisperMessageVideoMediaTypeListSpecified = true;
                _whisperMessageVideoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        public bool WhisperMessageVideoMediaTypeListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 _estimatedWaitMessageOptionsRead;

        [XmlElement(ElementName = "estimatedWaitMessageOptionsRead", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 EstimatedWaitMessageOptionsRead
        {
            get => _estimatedWaitMessageOptionsRead;
            set
            {
                EstimatedWaitMessageOptionsReadSpecified = true;
                _estimatedWaitMessageOptionsRead = value;
            }
        }

        [XmlIgnore]
        public bool EstimatedWaitMessageOptionsReadSpecified { get; set; }
    }
}
