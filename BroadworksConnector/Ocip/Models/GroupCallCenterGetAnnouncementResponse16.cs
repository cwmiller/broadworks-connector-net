using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest16.
    /// <see cref="GroupCallCenterGetAnnouncementRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:5302""}]")]
    public class GroupCallCenterGetAnnouncementResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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

        protected string _entranceAudioFileUrl;

        [XmlElement(ElementName = "entranceAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceAudioFileUrl
        {
            get => _entranceAudioFileUrl;
            set
            {
                EntranceAudioFileUrlSpecified = true;
                _entranceAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceAudioFileUrlSpecified { get; set; }

        protected string _entranceMessageAudioFileDescription;

        [XmlElement(ElementName = "entranceMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceMessageAudioFileDescription
        {
            get => _entranceMessageAudioFileDescription;
            set
            {
                EntranceMessageAudioFileDescriptionSpecified = true;
                _entranceMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _entranceAudioFileMediaType;

        [XmlElement(ElementName = "entranceAudioFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.MediaFileType EntranceAudioFileMediaType
        {
            get => _entranceAudioFileMediaType;
            set
            {
                EntranceAudioFileMediaTypeSpecified = true;
                _entranceAudioFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceAudioFileMediaTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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

        protected string _entranceVideoFileUrl;

        [XmlElement(ElementName = "entranceVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceVideoFileUrl
        {
            get => _entranceVideoFileUrl;
            set
            {
                EntranceVideoFileUrlSpecified = true;
                _entranceVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceVideoFileUrlSpecified { get; set; }

        protected string _entranceMessageVideoFileDescription;

        [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceMessageVideoFileDescription
        {
            get => _entranceMessageVideoFileDescription;
            set
            {
                EntranceMessageVideoFileDescriptionSpecified = true;
                _entranceMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _entranceVideoFileMediaType;

        [XmlElement(ElementName = "entranceVideoFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.MediaFileType EntranceVideoFileMediaType
        {
            get => _entranceVideoFileMediaType;
            set
            {
                EntranceVideoFileMediaTypeSpecified = true;
                _entranceVideoFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceVideoFileMediaTypeSpecified { get; set; }

        protected bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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

        protected string _periodicComfortAudioFileUrl;

        [XmlElement(ElementName = "periodicComfortAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortAudioFileUrl
        {
            get => _periodicComfortAudioFileUrl;
            set
            {
                PeriodicComfortAudioFileUrlSpecified = true;
                _periodicComfortAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortAudioFileUrlSpecified { get; set; }

        protected string _periodicComfortMessageAudioFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortMessageAudioFileDescription
        {
            get => _periodicComfortMessageAudioFileDescription;
            set
            {
                PeriodicComfortMessageAudioFileDescriptionSpecified = true;
                _periodicComfortMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _periodicComfortAudioFileMediaType;

        [XmlElement(ElementName = "periodicComfortAudioFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.MediaFileType PeriodicComfortAudioFileMediaType
        {
            get => _periodicComfortAudioFileMediaType;
            set
            {
                PeriodicComfortAudioFileMediaTypeSpecified = true;
                _periodicComfortAudioFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortAudioFileMediaTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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

        protected string _periodicComfortVideoFileUrl;

        [XmlElement(ElementName = "periodicComfortVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortVideoFileUrl
        {
            get => _periodicComfortVideoFileUrl;
            set
            {
                PeriodicComfortVideoFileUrlSpecified = true;
                _periodicComfortVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortVideoFileUrlSpecified { get; set; }

        protected string _periodicComfortMessageVideoFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortMessageVideoFileDescription
        {
            get => _periodicComfortMessageVideoFileDescription;
            set
            {
                PeriodicComfortMessageVideoFileDescriptionSpecified = true;
                _periodicComfortMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _periodicComfortVideoFileMediaType;

        [XmlElement(ElementName = "periodicComfortVideoFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.MediaFileType PeriodicComfortVideoFileMediaType
        {
            get => _periodicComfortVideoFileMediaType;
            set
            {
                PeriodicComfortVideoFileMediaTypeSpecified = true;
                _periodicComfortVideoFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortVideoFileMediaTypeSpecified { get; set; }

        protected bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldSource
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

        protected bool _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
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
        protected bool MediaOnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5302")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldInternalSource
        {
            get => _mediaOnHoldInternalSource;
            set
            {
                MediaOnHoldInternalSourceSpecified = true;
                _mediaOnHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        protected bool MediaOnHoldInternalSourceSpecified { get; set; }

    }
}
