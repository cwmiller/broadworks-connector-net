using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Estimated Wait Message Options
    /// 
    /// Replaced by EstimatedWaitMessageOptionsRead17sp4
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44379""}]")]
    public class EstimatedWaitMessageOptionsRead
    {

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode _operatingMode;

        [XmlElement(ElementName = "operatingMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        public BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode OperatingMode
        {
            get => _operatingMode;
            set
            {
                OperatingModeSpecified = true;
                _operatingMode = value;
            }
        }

        [XmlIgnore]
        protected bool OperatingModeSpecified { get; set; }

        private bool _playPositionHighVolume;

        [XmlElement(ElementName = "playPositionHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        public bool PlayPositionHighVolume
        {
            get => _playPositionHighVolume;
            set
            {
                PlayPositionHighVolumeSpecified = true;
                _playPositionHighVolume = value;
            }
        }

        [XmlIgnore]
        protected bool PlayPositionHighVolumeSpecified { get; set; }

        private bool _playTimeHighVolume;

        [XmlElement(ElementName = "playTimeHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        public bool PlayTimeHighVolume
        {
            get => _playTimeHighVolume;
            set
            {
                PlayTimeHighVolumeSpecified = true;
                _playTimeHighVolume = value;
            }
        }

        [XmlIgnore]
        protected bool PlayTimeHighVolumeSpecified { get; set; }

        private int _maximumPositions;

        [XmlElement(ElementName = "maximumPositions", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaximumPositions
        {
            get => _maximumPositions;
            set
            {
                MaximumPositionsSpecified = true;
                _maximumPositions = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumPositionsSpecified { get; set; }

        private int _maximumWaitingMinutes;

        [XmlElement(ElementName = "maximumWaitingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaximumWaitingMinutes
        {
            get => _maximumWaitingMinutes;
            set
            {
                MaximumWaitingMinutesSpecified = true;
                _maximumWaitingMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumWaitingMinutesSpecified { get; set; }

        private int _defaultCallHandlingMinutes;

        [XmlElement(ElementName = "defaultCallHandlingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44379")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int DefaultCallHandlingMinutes
        {
            get => _defaultCallHandlingMinutes;
            set
            {
                DefaultCallHandlingMinutesSpecified = true;
                _defaultCallHandlingMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultCallHandlingMinutesSpecified { get; set; }

    }
}
