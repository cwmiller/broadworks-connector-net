using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Estimated Wait Message Options
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2227""}]")]
    public class EstimatedWaitMessageOptionsRead17sp4
    {

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool EnabledSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode _operatingMode;

        [XmlElement(ElementName = "operatingMode", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool OperatingModeSpecified { get; set; }

        private bool _playPositionHighVolume;

        [XmlElement(ElementName = "playPositionHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool PlayPositionHighVolumeSpecified { get; set; }

        private bool _playTimeHighVolume;

        [XmlElement(ElementName = "playTimeHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool PlayTimeHighVolumeSpecified { get; set; }

        private int _maximumPositions;

        [XmlElement(ElementName = "maximumPositions", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool MaximumPositionsSpecified { get; set; }

        private int _maximumWaitingMinutes;

        [XmlElement(ElementName = "maximumWaitingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool MaximumWaitingMinutesSpecified { get; set; }

        private int _defaultCallHandlingMinutes;

        [XmlElement(ElementName = "defaultCallHandlingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
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
        public bool DefaultCallHandlingMinutesSpecified { get; set; }

        private bool _playUpdatedEWM;

        [XmlElement(ElementName = "playUpdatedEWM", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
        public bool PlayUpdatedEWM
        {
            get => _playUpdatedEWM;
            set
            {
                PlayUpdatedEWMSpecified = true;
                _playUpdatedEWM = value;
            }
        }

        [XmlIgnore]
        public bool PlayUpdatedEWMSpecified { get; set; }

        private int _timeBetweenEWMUpdatesSeconds;

        [XmlElement(ElementName = "timeBetweenEWMUpdatesSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2227")]
        [MinInclusive(10)]
        [MaxInclusive(600)]
        public int TimeBetweenEWMUpdatesSeconds
        {
            get => _timeBetweenEWMUpdatesSeconds;
            set
            {
                TimeBetweenEWMUpdatesSecondsSpecified = true;
                _timeBetweenEWMUpdatesSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeBetweenEWMUpdatesSecondsSpecified { get; set; }

    }
}
