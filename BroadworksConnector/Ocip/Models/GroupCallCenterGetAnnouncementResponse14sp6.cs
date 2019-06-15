using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest14sp6.
        /// <see cref="GroupCallCenterGetAnnouncementRequest14sp6"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetAnnouncementResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

        [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection {
            get => _entranceMessageSelection;
            set {
                EntranceMessageSelectionSpecified = true;
                _entranceMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool EntranceMessageSelectionSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

        [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection {
            get => _periodicComfortMessageSelection;
            set {
                PeriodicComfortMessageSelectionSpecified = true;
                _periodicComfortMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool PeriodicComfortMessageSelectionSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead _onHoldSource;

        [XmlElement(ElementName = "onHoldSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldSource {
            get => _onHoldSource;
            set {
                OnHoldSourceSpecified = true;
                _onHoldSource = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldSourceSpecified { get; set; }
        
        private bool _onHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "onHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        public bool OnHoldUseAlternateSourceForInternalCalls {
            get => _onHoldUseAlternateSourceForInternalCalls;
            set {
                OnHoldUseAlternateSourceForInternalCallsSpecified = true;
                _onHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead _onHoldInternalSource;

        [XmlElement(ElementName = "onHoldInternalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldInternalSource {
            get => _onHoldInternalSource;
            set {
                OnHoldInternalSourceSpecified = true;
                _onHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldInternalSourceSpecified { get; set; }
        
    }
}
