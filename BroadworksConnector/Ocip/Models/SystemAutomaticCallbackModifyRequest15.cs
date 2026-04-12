using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's automatic callback attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6e1812074dca6af91b3958d73ab352fc:143""}]")]
    public class SystemAutomaticCallbackModifyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int? _monitorMinutes;

        [XmlElement(ElementName = "monitorMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(5)]
        [MaxInclusive(180)]
        public int? MonitorMinutes
        {
            get => _monitorMinutes;
            set
            {
                MonitorMinutesSpecified = (value != null);
                _monitorMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MonitorMinutesSpecified { get; set; }

        protected int? _maxMonitorsPerOriginator;

        [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int? MaxMonitorsPerOriginator
        {
            get => _maxMonitorsPerOriginator;
            set
            {
                MaxMonitorsPerOriginatorSpecified = (value != null);
                _maxMonitorsPerOriginator = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMonitorsPerOriginatorSpecified { get; set; }

        protected int? _maxCallbackRings;

        [XmlElement(ElementName = "maxCallbackRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(3)]
        [MaxInclusive(8)]
        public int? MaxCallbackRings
        {
            get => _maxCallbackRings;
            set
            {
                MaxCallbackRingsSpecified = (value != null);
                _maxCallbackRings = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCallbackRingsSpecified { get; set; }

        protected int? _maxMonitorsPerTerminator;

        [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int? MaxMonitorsPerTerminator
        {
            get => _maxMonitorsPerTerminator;
            set
            {
                MaxMonitorsPerTerminatorSpecified = (value != null);
                _maxMonitorsPerTerminator = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMonitorsPerTerminatorSpecified { get; set; }

        protected int? _terminatorIdleGuardSeconds;

        [XmlElement(ElementName = "terminatorIdleGuardSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(5)]
        [MaxInclusive(300)]
        public int? TerminatorIdleGuardSeconds
        {
            get => _terminatorIdleGuardSeconds;
            set
            {
                TerminatorIdleGuardSecondsSpecified = (value != null);
                _terminatorIdleGuardSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatorIdleGuardSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutomaticCallbackMethod? _callbackMethod;

        [XmlElement(ElementName = "callbackMethod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        public BroadWorksConnector.Ocip.Models.AutomaticCallbackMethod? CallbackMethod
        {
            get => _callbackMethod;
            set
            {
                CallbackMethodSpecified = (value != null);
                _callbackMethod = value;
            }
        }

        [XmlIgnore]
        protected bool CallbackMethodSpecified { get; set; }

        protected int? _pollingIntervalSeconds;

        [XmlElement(ElementName = "pollingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(60)]
        [MaxInclusive(900)]
        public int? PollingIntervalSeconds
        {
            get => _pollingIntervalSeconds;
            set
            {
                PollingIntervalSecondsSpecified = (value != null);
                _pollingIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PollingIntervalSecondsSpecified { get; set; }

        protected int? _activationDigit;

        [XmlElement(ElementName = "activationDigit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:143")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int? ActivationDigit
        {
            get => _activationDigit;
            set
            {
                ActivationDigitSpecified = (value != null);
                _activationDigit = value;
            }
        }

        [XmlIgnore]
        protected bool ActivationDigitSpecified { get; set; }

    }
}
