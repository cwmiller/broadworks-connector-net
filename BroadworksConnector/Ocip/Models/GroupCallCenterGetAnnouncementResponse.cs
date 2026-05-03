using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAnnouncementRequest.
    /// <see cref="GroupCallCenterGetAnnouncementRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:5702""}]")]
    public class GroupCallCenterGetAnnouncementResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

        [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceMessageAudioFileDescription
        {
            get => _entranceMessageAudioFileDescription;
            set
            {
                EntranceMessageAudioFileDescriptionSpecified = (value != null);
                _entranceMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileDescriptionSpecified { get; set; }

        protected string _entranceMessageVideoFileDescription;

        [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceMessageVideoFileDescription
        {
            get => _entranceMessageVideoFileDescription;
            set
            {
                EntranceMessageVideoFileDescriptionSpecified = (value != null);
                _entranceMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

        [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortMessageAudioFileDescription
        {
            get => _periodicComfortMessageAudioFileDescription;
            set
            {
                PeriodicComfortMessageAudioFileDescriptionSpecified = (value != null);
                _periodicComfortMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileDescriptionSpecified { get; set; }

        protected string _periodicComfortMessageVideoFileDescription;

        [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PeriodicComfortMessageVideoFileDescription
        {
            get => _periodicComfortMessageVideoFileDescription;
            set
            {
                PeriodicComfortMessageVideoFileDescriptionSpecified = (value != null);
                _periodicComfortMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _onHoldMessageSelection;

        [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
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

        protected string _onHoldMessageAudioFileDescription;

        [XmlElement(ElementName = "onHoldMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string OnHoldMessageAudioFileDescription
        {
            get => _onHoldMessageAudioFileDescription;
            set
            {
                OnHoldMessageAudioFileDescriptionSpecified = (value != null);
                _onHoldMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldMessageAudioFileDescriptionSpecified { get; set; }

        protected string _onHoldMessageVideoFileDescription;

        [XmlElement(ElementName = "onHoldMessageVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:5702")]
        [MinLength(1)]
        [MaxLength(256)]
        public string OnHoldMessageVideoFileDescription
        {
            get => _onHoldMessageVideoFileDescription;
            set
            {
                OnHoldMessageVideoFileDescriptionSpecified = (value != null);
                _onHoldMessageVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldMessageVideoFileDescriptionSpecified { get; set; }

    }
}
