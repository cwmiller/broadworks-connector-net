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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e8188f390ad4fcfad616cb409dd0e896:143""}]")]
    public class SystemAutomaticCallbackModifyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _monitorMinutes;

        [XmlElement(ElementName = "monitorMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private int _maxMonitorsPerOriginator;

        [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private int _maxMonitorsPerTerminator;

        [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private int _terminatorIdleGuardSeconds;

        [XmlElement(ElementName = "terminatorIdleGuardSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private BroadWorksConnector.Ocip.Models.AutomaticCallbackMethod _callbackMethod;

        [XmlElement(ElementName = "callbackMethod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private int _pollingIntervalSeconds;

        [XmlElement(ElementName = "pollingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
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

        private int _activationDigit;

        [XmlElement(ElementName = "activationDigit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:143")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int ActivationDigit
        {
            get => _activationDigit;
            set
            {
                ActivationDigitSpecified = true;
                _activationDigit = value;
            }
        }

        [XmlIgnore]
        protected bool ActivationDigitSpecified { get; set; }

    }
}
