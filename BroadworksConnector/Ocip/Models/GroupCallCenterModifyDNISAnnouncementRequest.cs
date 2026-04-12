using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center DNIS announcement settings.
    /// The response is either a SuccessResponse or an
    /// ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6702""}]")]
    public class GroupCallCenterModifyDNISAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey
        {
            get => _dnisKey;
            set
            {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        protected bool DnisKeySpecified { get; set; }

        protected bool? _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public bool? PlayEntranceMessage
        {
            get => _playEntranceMessage;
            set
            {
                PlayEntranceMessageSpecified = (value != null);
                _playEntranceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEntranceMessageSpecified { get; set; }

        protected bool? _mandatoryEntranceMessage;

        [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public bool? MandatoryEntranceMessage
        {
            get => _mandatoryEntranceMessage;
            set
            {
                MandatoryEntranceMessageSpecified = (value != null);
                _mandatoryEntranceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool MandatoryEntranceMessageSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _entranceAudioMessageSelection;

        [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? EntranceAudioMessageSelection
        {
            get => _entranceAudioMessageSelection;
            set
            {
                EntranceAudioMessageSelectionSpecified = (value != null);
                _entranceAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceAudioMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _entranceMessageAudioUrlList;

        [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageAudioUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _entranceMessageAudioFileList;

        [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageAudioFileList
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _entranceMessageVideoUrlList;

        [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageVideoUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _entranceMessageVideoFileList;

        [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageVideoFileList
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

        protected bool? _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public bool? PlayPeriodicComfortMessage
        {
            get => _playPeriodicComfortMessage;
            set
            {
                PlayPeriodicComfortMessageSpecified = (value != null);
                _playPeriodicComfortMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayPeriodicComfortMessageSpecified { get; set; }

        protected int? _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        [MinInclusive(10)]
        [MaxInclusive(600)]
        public int? TimeBetweenComfortMessagesSeconds
        {
            get => _timeBetweenComfortMessagesSeconds;
            set
            {
                TimeBetweenComfortMessagesSecondsSpecified = (value != null);
                _timeBetweenComfortMessagesSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _periodicComfortAudioMessageSelection;

        [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? PeriodicComfortAudioMessageSelection
        {
            get => _periodicComfortAudioMessageSelection;
            set
            {
                PeriodicComfortAudioMessageSelectionSpecified = (value != null);
                _periodicComfortAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortAudioMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _periodicComfortMessageAudioUrlList;

        [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageAudioUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _periodicComfortMessageAudioFileList;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageAudioFileList
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _periodicComfortMessageVideoUrlList;

        [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageVideoUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _periodicComfortMessageVideoFileList;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageVideoFileList
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

        protected bool? _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public bool? EnableMediaOnHoldForQueuedCalls
        {
            get => _enableMediaOnHoldForQueuedCalls;
            set
            {
                EnableMediaOnHoldForQueuedCallsSpecified = (value != null);
                _enableMediaOnHoldForQueuedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMediaOnHoldForQueuedCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 MediaOnHoldSource
        {
            get => _mediaOnHoldSource;
            set
            {
                MediaOnHoldSourceSpecified = (value != null);
                _mediaOnHoldSource = value;
            }
        }

        [XmlIgnore]
        protected bool MediaOnHoldSourceSpecified { get; set; }

        protected bool? _playWhisperMessage;

        [XmlElement(ElementName = "playWhisperMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _whisperMessageAudioUrlList;

        [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageAudioUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _whisperMessageAudioFileList;

        [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageAudioFileList
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _whisperMessageVideoUrlList;

        [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageVideoUrlList
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _whisperMessageVideoFileList;

        [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageVideoFileList
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

        protected BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsModify _estimatedWaitMessageOptionsModify;

        [XmlElement(ElementName = "estimatedWaitMessageOptionsModify", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6702")]
        public BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsModify EstimatedWaitMessageOptionsModify
        {
            get => _estimatedWaitMessageOptionsModify;
            set
            {
                EstimatedWaitMessageOptionsModifySpecified = (value != null);
                _estimatedWaitMessageOptionsModify = value;
            }
        }

        [XmlIgnore]
        protected bool EstimatedWaitMessageOptionsModifySpecified { get; set; }

    }
}
