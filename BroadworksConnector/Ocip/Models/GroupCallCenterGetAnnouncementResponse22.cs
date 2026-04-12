using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest22.
    /// <see cref="GroupCallCenterGetAnnouncementRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4084""}]")]
    public class GroupCallCenterGetAnnouncementResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected bool _mandatoryEntranceMessage;

        [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceAudioMessageSelection;

        [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageAudioUrlList;

        [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageAudioUrlList
        {
            get => _entranceMessageAudioUrlList;
            set
            {
                EntranceMessageAudioUrlListSpecified = (value != null);
                _entranceMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _entranceMessageAudioFileList;

        [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 EntranceMessageAudioFileList
        {
            get => _entranceMessageAudioFileList;
            set
            {
                EntranceMessageAudioFileListSpecified = (value != null);
                _entranceMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? EntranceVideoMessageSelection
        {
            get => _entranceVideoMessageSelection;
            set
            {
                EntranceVideoMessageSelectionSpecified = (value != null);
                _entranceVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceVideoMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _entranceMessageVideoUrlList;

        [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageVideoUrlList
        {
            get => _entranceMessageVideoUrlList;
            set
            {
                EntranceMessageVideoUrlListSpecified = (value != null);
                _entranceMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _entranceMessageVideoFileList;

        [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 EntranceMessageVideoFileList
        {
            get => _entranceMessageVideoFileList;
            set
            {
                EntranceMessageVideoFileListSpecified = (value != null);
                _entranceMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileListSpecified { get; set; }

        protected bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortAudioMessageSelection;

        [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageAudioUrlList;

        [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageAudioUrlList
        {
            get => _periodicComfortMessageAudioUrlList;
            set
            {
                PeriodicComfortMessageAudioUrlListSpecified = (value != null);
                _periodicComfortMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _periodicComfortMessageAudioFileList;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 PeriodicComfortMessageAudioFileList
        {
            get => _periodicComfortMessageAudioFileList;
            set
            {
                PeriodicComfortMessageAudioFileListSpecified = (value != null);
                _periodicComfortMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? PeriodicComfortVideoMessageSelection
        {
            get => _periodicComfortVideoMessageSelection;
            set
            {
                PeriodicComfortVideoMessageSelectionSpecified = (value != null);
                _periodicComfortVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortVideoMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _periodicComfortMessageVideoUrlList;

        [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageVideoUrlList
        {
            get => _periodicComfortMessageVideoUrlList;
            set
            {
                PeriodicComfortMessageVideoUrlListSpecified = (value != null);
                _periodicComfortMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _periodicComfortMessageVideoFileList;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 PeriodicComfortMessageVideoFileList
        {
            get => _periodicComfortMessageVideoFileList;
            set
            {
                PeriodicComfortMessageVideoFileListSpecified = (value != null);
                _periodicComfortMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileListSpecified { get; set; }

        protected bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 MediaOnHoldSource
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

        protected bool? _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public bool? MediaOnHoldUseAlternateSourceForInternalCalls
        {
            get => _mediaOnHoldUseAlternateSourceForInternalCalls;
            set
            {
                MediaOnHoldUseAlternateSourceForInternalCallsSpecified = (value != null);
                _mediaOnHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MediaOnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 MediaOnHoldInternalSource
        {
            get => _mediaOnHoldInternalSource;
            set
            {
                MediaOnHoldInternalSourceSpecified = (value != null);
                _mediaOnHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        protected bool MediaOnHoldInternalSourceSpecified { get; set; }

        protected bool? _playWhisperMessage;

        [XmlElement(ElementName = "playWhisperMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public bool? PlayWhisperMessage
        {
            get => _playWhisperMessage;
            set
            {
                PlayWhisperMessageSpecified = (value != null);
                _playWhisperMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayWhisperMessageSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _whisperAudioMessageSelection;

        [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? WhisperAudioMessageSelection
        {
            get => _whisperAudioMessageSelection;
            set
            {
                WhisperAudioMessageSelectionSpecified = (value != null);
                _whisperAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperAudioMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageAudioUrlList;

        [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageAudioUrlList
        {
            get => _whisperMessageAudioUrlList;
            set
            {
                WhisperMessageAudioUrlListSpecified = (value != null);
                _whisperMessageAudioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageAudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _whisperMessageAudioFileList;

        [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 WhisperMessageAudioFileList
        {
            get => _whisperMessageAudioFileList;
            set
            {
                WhisperMessageAudioFileListSpecified = (value != null);
                _whisperMessageAudioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageAudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _whisperVideoMessageSelection;

        [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? WhisperVideoMessageSelection
        {
            get => _whisperVideoMessageSelection;
            set
            {
                WhisperVideoMessageSelectionSpecified = (value != null);
                _whisperVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperVideoMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _whisperMessageVideoUrlList;

        [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageVideoUrlList
        {
            get => _whisperMessageVideoUrlList;
            set
            {
                WhisperMessageVideoUrlListSpecified = (value != null);
                _whisperMessageVideoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageVideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _whisperMessageVideoFileList;

        [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 WhisperMessageVideoFileList
        {
            get => _whisperMessageVideoFileList;
            set
            {
                WhisperMessageVideoFileListSpecified = (value != null);
                _whisperMessageVideoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool WhisperMessageVideoFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 _estimatedWaitMessageOptionsRead;

        [XmlElement(ElementName = "estimatedWaitMessageOptionsRead", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4084")]
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
