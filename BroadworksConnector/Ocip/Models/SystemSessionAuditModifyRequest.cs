using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with session sudit.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: SystemSessionAuditModifyRequest14sp3
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSessionAuditModifyRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5695""}]")]
    public class SystemSessionAuditModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5695")]
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
        protected bool IsActiveSpecified { get; set; }

        private int _intervalSeconds;

        [XmlElement(ElementName = "intervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5695")]
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
        protected bool IntervalSecondsSpecified { get; set; }

        private int _timeoutPeriodSeconds;

        [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5695")]
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
        protected bool TimeoutPeriodSecondsSpecified { get; set; }

    }
}
