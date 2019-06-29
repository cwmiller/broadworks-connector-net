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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:1077""}]")]
    public class GroupCallCenterModifyAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

        [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection
        {
            get => _entranceMessageSelection;
            set
            {
                EntranceMessageSelectionSpecified = true;
                _entranceMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageAudioFile;

        [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageAudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageVideoFile;

        [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageVideoFile
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

        [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection
        {
            get => _periodicComfortMessageSelection;
            set
            {
                PeriodicComfortMessageSelectionSpecified = true;
                _periodicComfortMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageAudioFile;

        [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageAudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageVideoFile;

        [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageVideoFile
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _onHoldMessageSelection;

        [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection OnHoldMessageSelection
        {
            get => _onHoldMessageSelection;
            set
            {
                OnHoldMessageSelectionSpecified = true;
                _onHoldMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _onHoldMessageAudioFile;

        [XmlElement(ElementName = "onHoldMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource OnHoldMessageAudioFile
        {
            get => _onHoldMessageAudioFile;
            set
            {
                OnHoldMessageAudioFileSpecified = true;
                _onHoldMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldMessageAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _onHoldMessageVideoFile;

        [XmlElement(ElementName = "onHoldMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:1077")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource OnHoldMessageVideoFile
        {
            get => _onHoldMessageVideoFile;
            set
            {
                OnHoldMessageVideoFileSpecified = true;
                _onHoldMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldMessageVideoFileSpecified { get; set; }

    }
}
