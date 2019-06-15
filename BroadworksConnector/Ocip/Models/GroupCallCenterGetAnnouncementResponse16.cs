using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest16.
        /// <see cref="GroupCallCenterGetAnnouncementRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetAnnouncementResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _playEntranceMessage;

        [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
        public bool PlayEntranceMessage {
            get => _playEntranceMessage;
            set {
                PlayEntranceMessageSpecified = true;
                _playEntranceMessage = value;
            }
        }

        [XmlIgnore]
        public bool PlayEntranceMessageSpecified { get; set; }
        
        private bool _mandatoryEntranceMessage;

        [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
        public bool MandatoryEntranceMessage {
            get => _mandatoryEntranceMessage;
            set {
                MandatoryEntranceMessageSpecified = true;
                _mandatoryEntranceMessage = value;
            }
        }

        [XmlIgnore]
        public bool MandatoryEntranceMessageSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceAudioMessageSelection;

        [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection {
            get => _entranceAudioMessageSelection;
            set {
                EntranceAudioMessageSelectionSpecified = true;
                _entranceAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool EntranceAudioMessageSelectionSpecified { get; set; }
        
        private string _entranceAudioFileUrl;

        [XmlElement(ElementName = "entranceAudioFileUrl", IsNullable = false, Namespace = "")]
        public string EntranceAudioFileUrl {
            get => _entranceAudioFileUrl;
            set {
                EntranceAudioFileUrlSpecified = true;
                _entranceAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool EntranceAudioFileUrlSpecified { get; set; }
        
        private string _entranceMessageAudioFileDescription;

        [XmlElement(ElementName = "entranceMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        public string EntranceMessageAudioFileDescription {
            get => _entranceMessageAudioFileDescription;
            set {
                EntranceMessageAudioFileDescriptionSpecified = true;
                _entranceMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageAudioFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _entranceAudioFileMediaType;

        [XmlElement(ElementName = "entranceAudioFileMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType EntranceAudioFileMediaType {
            get => _entranceAudioFileMediaType;
            set {
                EntranceAudioFileMediaTypeSpecified = true;
                _entranceAudioFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool EntranceAudioFileMediaTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

        [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection {
            get => _entranceVideoMessageSelection;
            set {
                EntranceVideoMessageSelectionSpecified = true;
                _entranceVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool EntranceVideoMessageSelectionSpecified { get; set; }
        
        private string _entranceVideoFileUrl;

        [XmlElement(ElementName = "entranceVideoFileUrl", IsNullable = false, Namespace = "")]
        public string EntranceVideoFileUrl {
            get => _entranceVideoFileUrl;
            set {
                EntranceVideoFileUrlSpecified = true;
                _entranceVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool EntranceVideoFileUrlSpecified { get; set; }
        
        private string _entranceMessageVideoFileDescription;

        [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        public string EntranceMessageVideoFileDescription {
            get => _entranceMessageVideoFileDescription;
            set {
                EntranceMessageVideoFileDescriptionSpecified = true;
                _entranceMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageVideoFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _entranceVideoFileMediaType;

        [XmlElement(ElementName = "entranceVideoFileMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType EntranceVideoFileMediaType {
            get => _entranceVideoFileMediaType;
            set {
                EntranceVideoFileMediaTypeSpecified = true;
                _entranceVideoFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool EntranceVideoFileMediaTypeSpecified { get; set; }
        
        private bool _playPeriodicComfortMessage;

        [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
        public bool PlayPeriodicComfortMessage {
            get => _playPeriodicComfortMessage;
            set {
                PlayPeriodicComfortMessageSpecified = true;
                _playPeriodicComfortMessage = value;
            }
        }

        [XmlIgnore]
        public bool PlayPeriodicComfortMessageSpecified { get; set; }
        
        private int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        public int TimeBetweenComfortMessagesSeconds {
            get => _timeBetweenComfortMessagesSeconds;
            set {
                TimeBetweenComfortMessagesSecondsSpecified = true;
                _timeBetweenComfortMessagesSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortAudioMessageSelection;

        [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection {
            get => _periodicComfortAudioMessageSelection;
            set {
                PeriodicComfortAudioMessageSelectionSpecified = true;
                _periodicComfortAudioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortAudioMessageSelectionSpecified { get; set; }
        
        private string _periodicComfortAudioFileUrl;

        [XmlElement(ElementName = "periodicComfortAudioFileUrl", IsNullable = false, Namespace = "")]
        public string PeriodicComfortAudioFileUrl {
            get => _periodicComfortAudioFileUrl;
            set {
                PeriodicComfortAudioFileUrlSpecified = true;
                _periodicComfortAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortAudioFileUrlSpecified { get; set; }
        
        private string _periodicComfortMessageAudioFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        public string PeriodicComfortMessageAudioFileDescription {
            get => _periodicComfortMessageAudioFileDescription;
            set {
                PeriodicComfortMessageAudioFileDescriptionSpecified = true;
                _periodicComfortMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageAudioFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _periodicComfortAudioFileMediaType;

        [XmlElement(ElementName = "periodicComfortAudioFileMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType PeriodicComfortAudioFileMediaType {
            get => _periodicComfortAudioFileMediaType;
            set {
                PeriodicComfortAudioFileMediaTypeSpecified = true;
                _periodicComfortAudioFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortAudioFileMediaTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

        [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection {
            get => _periodicComfortVideoMessageSelection;
            set {
                PeriodicComfortVideoMessageSelectionSpecified = true;
                _periodicComfortVideoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortVideoMessageSelectionSpecified { get; set; }
        
        private string _periodicComfortVideoFileUrl;

        [XmlElement(ElementName = "periodicComfortVideoFileUrl", IsNullable = false, Namespace = "")]
        public string PeriodicComfortVideoFileUrl {
            get => _periodicComfortVideoFileUrl;
            set {
                PeriodicComfortVideoFileUrlSpecified = true;
                _periodicComfortVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortVideoFileUrlSpecified { get; set; }
        
        private string _periodicComfortMessageVideoFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        public string PeriodicComfortMessageVideoFileDescription {
            get => _periodicComfortMessageVideoFileDescription;
            set {
                PeriodicComfortMessageVideoFileDescriptionSpecified = true;
                _periodicComfortMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageVideoFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _periodicComfortVideoFileMediaType;

        [XmlElement(ElementName = "periodicComfortVideoFileMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType PeriodicComfortVideoFileMediaType {
            get => _periodicComfortVideoFileMediaType;
            set {
                PeriodicComfortVideoFileMediaTypeSpecified = true;
                _periodicComfortVideoFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortVideoFileMediaTypeSpecified { get; set; }
        
        private bool _enableMediaOnHoldForQueuedCalls;

        [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
        public bool EnableMediaOnHoldForQueuedCalls {
            get => _enableMediaOnHoldForQueuedCalls;
            set {
                EnableMediaOnHoldForQueuedCallsSpecified = true;
                _enableMediaOnHoldForQueuedCalls = value;
            }
        }

        [XmlIgnore]
        public bool EnableMediaOnHoldForQueuedCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldSource {
            get => _mediaOnHoldSource;
            set {
                MediaOnHoldSourceSpecified = true;
                _mediaOnHoldSource = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldSourceSpecified { get; set; }
        
        private bool _mediaOnHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        public bool MediaOnHoldUseAlternateSourceForInternalCalls {
            get => _mediaOnHoldUseAlternateSourceForInternalCalls;
            set {
                MediaOnHoldUseAlternateSourceForInternalCallsSpecified = true;
                _mediaOnHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 _mediaOnHoldInternalSource;

        [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldInternalSource {
            get => _mediaOnHoldInternalSource;
            set {
                MediaOnHoldInternalSourceSpecified = true;
                _mediaOnHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldInternalSourceSpecified { get; set; }
        
    }
}
