using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's announcement settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6669""}]")]
    public class GroupCallCenterModifyAnnouncementRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected bool? _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _entranceMessageAudioFile;

        [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageAudioFile
        {
            get => _entranceMessageAudioFile;
            set
            {
                EntranceMessageAudioFileSpecified = (value != null);
                _entranceMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _entranceMessageVideoFile;

        [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageVideoFile
        {
            get => _entranceMessageVideoFile;
            set
            {
                EntranceMessageVideoFileSpecified = (value != null);
                _entranceMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileSpecified { get; set; }

        protected bool? _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _periodicComfortMessageAudioFile;

        [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageAudioFile
        {
            get => _periodicComfortMessageAudioFile;
            set
            {
                PeriodicComfortMessageAudioFileSpecified = (value != null);
                _periodicComfortMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection? _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _periodicComfortMessageVideoFile;

        [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageVideoFile
        {
            get => _periodicComfortMessageVideoFile;
            set
            {
                PeriodicComfortMessageVideoFileSpecified = (value != null);
                _periodicComfortMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileSpecified { get; set; }

        protected bool? _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldSource
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

        protected bool? _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6669")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldInternalSource
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

    }
}
