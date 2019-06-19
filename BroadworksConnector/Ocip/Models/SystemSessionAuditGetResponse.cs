using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSessionAuditGetRequest.
    /// Replaced By: SystemSessionAuditGetResponse14sp3
    /// <see cref="SystemSessionAuditGetRequest"/>
    /// <see cref="SystemSessionAuditGetResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5676""}]")]
    public class SystemSessionAuditGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5676")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private int _intervalSeconds;

        [XmlElement(ElementName = "intervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5676")]
        [MinInclusive(60)]
        [MaxInclusive(7200)]
        public int IntervalSeconds
        {
            get => _intervalSeconds;
            set
            {
                IntervalSecondsSpecified = true;
                _intervalSeconds = value;
            }
        }

        [XmlIgnore]
        public bool IntervalSecondsSpecified { get; set; }

        private int _timeoutPeriodSeconds;

        [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5676")]
        [MinInclusive(60)]
        [MaxInclusive(600)]
        public int TimeoutPeriodSeconds
        {
            get => _timeoutPeriodSeconds;
            set
            {
                TimeoutPeriodSecondsSpecified = true;
                _timeoutPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutPeriodSecondsSpecified { get; set; }

    }
}
