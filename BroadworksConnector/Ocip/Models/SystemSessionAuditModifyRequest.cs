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
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:33832""}]")]
    public class SystemSessionAuditModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:33832")]
        public bool? IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = (value != null);
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected int? _intervalSeconds;

        [XmlElement(ElementName = "intervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:33832")]
        [MinInclusive(60)]
        [MaxInclusive(7200)]
        public int? IntervalSeconds
        {
            get => _intervalSeconds;
            set
            {
                IntervalSecondsSpecified = (value != null);
                _intervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool IntervalSecondsSpecified { get; set; }

        protected int? _timeoutPeriodSeconds;

        [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:33832")]
        [MinInclusive(60)]
        [MaxInclusive(600)]
        public int? TimeoutPeriodSeconds
        {
            get => _timeoutPeriodSeconds;
            set
            {
                TimeoutPeriodSecondsSpecified = (value != null);
                _timeoutPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeoutPeriodSecondsSpecified { get; set; }

    }
}
