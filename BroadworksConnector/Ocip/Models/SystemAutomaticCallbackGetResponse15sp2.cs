using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAutomaticCallbackGetRequest15sp2.
    /// <see cref="SystemAutomaticCallbackGetRequest15sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20694""}]")]
    public class SystemAutomaticCallbackGetResponse15sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _monitorMinutes;

        [XmlElement(ElementName = "monitorMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
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

        protected int _maxMonitorsPerOriginator;

        [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
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

        protected int _maxCallbackRings;

        [XmlElement(ElementName = "maxCallbackRings", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
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

        protected int _maxMonitorsPerTerminator;

        [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
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

        protected int _terminatorIdleGuardSeconds;

        [XmlElement(ElementName = "terminatorIdleGuardSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
        [MinInclusive(5)]
        [MaxInclusive(300)]
        public int TerminatorIdleGuardSeconds
        {
            get => _terminatorIdleGuardSeconds;
            set
            {
                TerminatorIdleGuardSecondsSpecified = true;
                _terminatorIdleGuardSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatorIdleGuardSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutomaticCallbackMethod _callbackMethod;

        [XmlElement(ElementName = "callbackMethod", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
        public BroadWorksConnector.Ocip.Models.AutomaticCallbackMethod CallbackMethod
        {
            get => _callbackMethod;
            set
            {
                CallbackMethodSpecified = true;
                _callbackMethod = value;
            }
        }

        [XmlIgnore]
        protected bool CallbackMethodSpecified { get; set; }

        protected int _pollingIntervalSeconds;

        [XmlElement(ElementName = "pollingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20694")]
        [MinInclusive(60)]
        [MaxInclusive(900)]
        public int PollingIntervalSeconds
        {
            get => _pollingIntervalSeconds;
            set
            {
                PollingIntervalSecondsSpecified = true;
                _pollingIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PollingIntervalSecondsSpecified { get; set; }

    }
}
