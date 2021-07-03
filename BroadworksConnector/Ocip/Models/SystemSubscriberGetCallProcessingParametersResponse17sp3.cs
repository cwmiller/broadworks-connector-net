using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetCallProcessingParametersRequest17sp3.
    /// <see cref="SystemSubscriberGetCallProcessingParametersRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35210""}]")]
    public class SystemSubscriberGetCallProcessingParametersResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isExtendedCallingLineIdActive;

        [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        public bool IsExtendedCallingLineIdActive
        {
            get => _isExtendedCallingLineIdActive;
            set
            {
                IsExtendedCallingLineIdActiveSpecified = true;
                _isExtendedCallingLineIdActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsExtendedCallingLineIdActiveSpecified { get; set; }

        private bool _isRingTimeOutActive;

        [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        public bool IsRingTimeOutActive
        {
            get => _isRingTimeOutActive;
            set
            {
                IsRingTimeOutActiveSpecified = true;
                _isRingTimeOutActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsRingTimeOutActiveSpecified { get; set; }

        private int _ringTimeoutSeconds;

        [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        [MinInclusive(1)]
        [MaxInclusive(180)]
        public int RingTimeoutSeconds
        {
            get => _ringTimeoutSeconds;
            set
            {
                RingTimeoutSecondsSpecified = true;
                _ringTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RingTimeoutSecondsSpecified { get; set; }

        private bool _allowEmergencyRemoteOfficeOriginations;

        [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        public bool AllowEmergencyRemoteOfficeOriginations
        {
            get => _allowEmergencyRemoteOfficeOriginations;
            set
            {
                AllowEmergencyRemoteOfficeOriginationsSpecified = true;
                _allowEmergencyRemoteOfficeOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool AllowEmergencyRemoteOfficeOriginationsSpecified { get; set; }

        private int _maxNoAnswerNumberOfRings;

        [XmlElement(ElementName = "maxNoAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        [MinInclusive(6)]
        [MaxInclusive(20)]
        public int MaxNoAnswerNumberOfRings
        {
            get => _maxNoAnswerNumberOfRings;
            set
            {
                MaxNoAnswerNumberOfRingsSpecified = true;
                _maxNoAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNoAnswerNumberOfRingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IncomingCallToUserAliasMode _incomingCallToUserAliasMode;

        [XmlElement(ElementName = "incomingCallToUserAliasMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        public BroadWorksConnector.Ocip.Models.IncomingCallToUserAliasMode IncomingCallToUserAliasMode
        {
            get => _incomingCallToUserAliasMode;
            set
            {
                IncomingCallToUserAliasModeSpecified = true;
                _incomingCallToUserAliasMode = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingCallToUserAliasModeSpecified { get; set; }

        private bool _bypassTerminationLoopDetection;

        [XmlElement(ElementName = "bypassTerminationLoopDetection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35210")]
        public bool BypassTerminationLoopDetection
        {
            get => _bypassTerminationLoopDetection;
            set
            {
                BypassTerminationLoopDetectionSpecified = true;
                _bypassTerminationLoopDetection = value;
            }
        }

        [XmlIgnore]
        protected bool BypassTerminationLoopDetectionSpecified { get; set; }

    }
}
