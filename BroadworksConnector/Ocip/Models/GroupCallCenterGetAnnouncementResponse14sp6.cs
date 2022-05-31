using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest14sp6.
    /// <see cref="GroupCallCenterGetAnnouncementRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5148""}]")]
    public class GroupCallCenterGetAnnouncementResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

        [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected string _entranceMessageAudioFileDescription;

        [XmlElement(ElementName = "entranceMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected string _entranceMessageVideoFileDescription;

        [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

        [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected string _periodicComfortMessageAudioFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected string _periodicComfortMessageVideoFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead _onHoldSource;

        [XmlElement(ElementName = "onHoldSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldSource
        {
            get => _onHoldSource;
            set
            {
                OnHoldSourceSpecified = true;
                _onHoldSource = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldSourceSpecified { get; set; }

        protected bool _onHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "onHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
        public bool OnHoldUseAlternateSourceForInternalCalls
        {
            get => _onHoldUseAlternateSourceForInternalCalls;
            set
            {
                OnHoldUseAlternateSourceForInternalCallsSpecified = true;
                _onHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead _onHoldInternalSource;

        [XmlElement(ElementName = "onHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5148")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldInternalSource
        {
            get => _onHoldInternalSource;
            set
            {
                OnHoldInternalSourceSpecified = true;
                _onHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldInternalSourceSpecified { get; set; }

    }
}
