using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAutomaticCallbackGetRequest.
    /// Replaced By: SystemAutomaticCallbackGetResponse15
    /// <see cref="SystemAutomaticCallbackGetRequest"/>
    /// <see cref="SystemAutomaticCallbackGetResponse15"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4281""}]")]
    public class SystemAutomaticCallbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _monitorMinutes;

        [XmlElement(ElementName = "monitorMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4281")]
        [MinInclusive(5)]
        [MaxInclusive(180)]
        public int MonitorMinutes
        {
            get => _monitorMinutes;
            set
            {
                MonitorMinutesSpecified = true;
                _monitorMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MonitorMinutesSpecified { get; set; }

        private int _waitBetweenRetryOriginatorMinutes;

        [XmlElement(ElementName = "waitBetweenRetryOriginatorMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4281")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int WaitBetweenRetryOriginatorMinutes
        {
            get => _waitBetweenRetryOriginatorMinutes;
            set
            {
                WaitBetweenRetryOriginatorMinutesSpecified = true;
                _waitBetweenRetryOriginatorMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool WaitBetweenRetryOriginatorMinutesSpecified { get; set; }

        private int _maxMonitorsPerOriginator;

        [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4281")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int MaxMonitorsPerOriginator
        {
            get => _maxMonitorsPerOriginator;
            set
            {
                MaxMonitorsPerOriginatorSpecified = true;
                _maxMonitorsPerOriginator = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMonitorsPerOriginatorSpecified { get; set; }

        private int _maxCallbackRings;

        [XmlElement(ElementName = "maxCallbackRings", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4281")]
        [MinInclusive(3)]
        [MaxInclusive(8)]
        public int MaxCallbackRings
        {
            get => _maxCallbackRings;
            set
            {
                MaxCallbackRingsSpecified = true;
                _maxCallbackRings = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCallbackRingsSpecified { get; set; }

        private int _maxRetryOriginatorMinutes;

        [XmlElement(ElementName = "maxRetryOriginatorMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4281")]
        [MinInclusive(180)]
        [MaxInclusive(360)]
        public int MaxRetryOriginatorMinutes
        {
            get => _maxRetryOriginatorMinutes;
            set
            {
                MaxRetryOriginatorMinutesSpecified = true;
                _maxRetryOriginatorMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxRetryOriginatorMinutesSpecified { get; set; }

    }
}
