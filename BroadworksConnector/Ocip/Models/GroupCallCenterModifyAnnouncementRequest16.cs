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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6537""}]")]
    public class GroupCallCenterModifyAnnouncementRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _entranceMessageAudioFile;

        [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageAudioFile
        {
            get => _entranceMessageAudioFile;
            set
            {
                EntranceMessageAudioFileSpecified = true;
                _entranceMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _entranceMessageVideoFile;

        [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageVideoFile
        {
            get => _entranceMessageVideoFile;
            set
            {
                EntranceMessageVideoFileSpecified = true;
                _entranceMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileSpecified { get; set; }

        private bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _periodicComfortMessageAudioFile;

        [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageAudioFile
        {
            get => _periodicComfortMessageAudioFile;
            set
            {
                PeriodicComfortMessageAudioFileSpecified = true;
                _periodicComfortMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _periodicComfortMessageVideoFile;

        [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageVideoFile
        {
            get => _periodicComfortMessageVideoFile;
            set
            {
                PeriodicComfortMessageVideoFileSpecified = true;
                _periodicComfortMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileSpecified { get; set; }

        private bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldSource
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

        private bool _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6537")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldInternalSource
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
