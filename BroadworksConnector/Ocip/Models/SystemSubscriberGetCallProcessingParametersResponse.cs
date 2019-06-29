using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetCallProcessingParametersRequest.
    /// Replaced By: SystemSubscriberGetCallProcessingParametersResponse14sp3
    /// <see cref="SystemSubscriberGetCallProcessingParametersRequest"/>
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6582""}]")]
    public class SystemSubscriberGetCallProcessingParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection _userCallingLineIdSelection;

        [XmlElement(ElementName = "userCallingLineIdSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6582")]
        public BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection UserCallingLineIdSelection
        {
            get => _userCallingLineIdSelection;
            set
            {
                UserCallingLineIdSelectionSpecified = true;
                _userCallingLineIdSelection = value;
            }
        }

        [XmlIgnore]
        protected bool UserCallingLineIdSelectionSpecified { get; set; }

        private bool _isExtendedCallingLineIdActive;

        [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6582")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6582")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6582")]
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

    }
}
