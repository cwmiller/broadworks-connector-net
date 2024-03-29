using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLegacyAutomaticCallbackGetRequest.
    /// <see cref="SystemLegacyAutomaticCallbackGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dd4a5e667a0f0e4bd6363152331d07ab:91""}]")]
    public class SystemLegacyAutomaticCallbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxMonitorsPerOriginator;

        [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
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

        protected int _maxMonitorsPerTerminator;

        [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int MaxMonitorsPerTerminator
        {
            get => _maxMonitorsPerTerminator;
            set
            {
                MaxMonitorsPerTerminatorSpecified = true;
                _maxMonitorsPerTerminator = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMonitorsPerTerminatorSpecified { get; set; }

        protected int _t2Minutes;

        [XmlElement(ElementName = "t2Minutes", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int T2Minutes
        {
            get => _t2Minutes;
            set
            {
                T2MinutesSpecified = true;
                _t2Minutes = value;
            }
        }

        [XmlIgnore]
        protected bool T2MinutesSpecified { get; set; }

        protected int _t4Seconds;

        [XmlElement(ElementName = "t4Seconds", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(0)]
        [MaxInclusive(15)]
        public int T4Seconds
        {
            get => _t4Seconds;
            set
            {
                T4SecondsSpecified = true;
                _t4Seconds = value;
            }
        }

        [XmlIgnore]
        protected bool T4SecondsSpecified { get; set; }

        protected int _t5Seconds;

        [XmlElement(ElementName = "t5Seconds", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int T5Seconds
        {
            get => _t5Seconds;
            set
            {
                T5SecondsSpecified = true;
                _t5Seconds = value;
            }
        }

        [XmlIgnore]
        protected bool T5SecondsSpecified { get; set; }

        protected int _t6Minutes;

        [XmlElement(ElementName = "t6Minutes", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int T6Minutes
        {
            get => _t6Minutes;
            set
            {
                T6MinutesSpecified = true;
                _t6Minutes = value;
            }
        }

        [XmlIgnore]
        protected bool T6MinutesSpecified { get; set; }

        protected int _t7Minutes;

        [XmlElement(ElementName = "t7Minutes", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(5)]
        [MaxInclusive(180)]
        public int T7Minutes
        {
            get => _t7Minutes;
            set
            {
                T7MinutesSpecified = true;
                _t7Minutes = value;
            }
        }

        [XmlIgnore]
        protected bool T7MinutesSpecified { get; set; }

        protected int _t8Seconds;

        [XmlElement(ElementName = "t8Seconds", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(0)]
        [MaxInclusive(120)]
        public int T8Seconds
        {
            get => _t8Seconds;
            set
            {
                T8SecondsSpecified = true;
                _t8Seconds = value;
            }
        }

        [XmlIgnore]
        protected bool T8SecondsSpecified { get; set; }

        protected int _tRingSeconds;

        [XmlElement(ElementName = "tRingSeconds", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int TRingSeconds
        {
            get => _tRingSeconds;
            set
            {
                TRingSecondsSpecified = true;
                _tRingSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TRingSecondsSpecified { get; set; }

        protected int _t10OMinutes;

        [XmlElement(ElementName = "t10OMinutes", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int T10OMinutes
        {
            get => _t10OMinutes;
            set
            {
                T10OMinutesSpecified = true;
                _t10OMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool T10OMinutesSpecified { get; set; }

        protected int _t10TMinutes;

        [XmlElement(ElementName = "t10TMinutes", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:91")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int T10TMinutes
        {
            get => _t10TMinutes;
            set
            {
                T10TMinutesSpecified = true;
                _t10TMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool T10TMinutesSpecified { get; set; }

    }
}
