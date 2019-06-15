using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest.
        /// <see cref="GroupCallCenterGetAnnouncementRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetAnnouncementResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _onHoldMessageSelection;

        [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection OnHoldMessageSelection {
            get => _onHoldMessageSelection;
            set {
                OnHoldMessageSelectionSpecified = true;
                _onHoldMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldMessageSelectionSpecified { get; set; }
        
        private string _onHoldMessageAudioFileDescription;

        [XmlElement(ElementName = "onHoldMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        public string OnHoldMessageAudioFileDescription {
            get => _onHoldMessageAudioFileDescription;
            set {
                OnHoldMessageAudioFileDescriptionSpecified = true;
                _onHoldMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldMessageAudioFileDescriptionSpecified { get; set; }
        
        private string _onHoldMessageVideoFileDescription;

        [XmlElement(ElementName = "onHoldMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        public string OnHoldMessageVideoFileDescription {
            get => _onHoldMessageVideoFileDescription;
            set {
                OnHoldMessageVideoFileDescriptionSpecified = true;
                _onHoldMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool OnHoldMessageVideoFileDescriptionSpecified { get; set; }
        
    }
}
