using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFAXMessagingGetRequest.
    /// 
    /// The following elements are only used in AS data mode:
    /// statusDurationHours
    /// statusAuditIntervalHours
    /// <see cref="SystemFAXMessagingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b2249333b9e085ee149c29960c00214e:60""}]")]
    public class SystemFaxMessagingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _statusDurationHours;

        [XmlElement(ElementName = "statusDurationHours", IsNullable = false, Namespace = "")]
        [Group(@"b2249333b9e085ee149c29960c00214e:60")]
        [MinInclusive(1)]
        [MaxInclusive(24)]
        public int StatusDurationHours
        {
            get => _statusDurationHours;
            set
            {
                StatusDurationHoursSpecified = true;
                _statusDurationHours = value;
            }
        }

        [XmlIgnore]
        protected bool StatusDurationHoursSpecified { get; set; }

        protected int _statusAuditIntervalHours;

        [XmlElement(ElementName = "statusAuditIntervalHours", IsNullable = false, Namespace = "")]
        [Group(@"b2249333b9e085ee149c29960c00214e:60")]
        [MinInclusive(1)]
        [MaxInclusive(24)]
        public int StatusAuditIntervalHours
        {
            get => _statusAuditIntervalHours;
            set
            {
                StatusAuditIntervalHoursSpecified = true;
                _statusAuditIntervalHours = value;
            }
        }

        [XmlIgnore]
        protected bool StatusAuditIntervalHoursSpecified { get; set; }

        protected int _maximumConcurrentFaxesPerUser;

        [XmlElement(ElementName = "maximumConcurrentFaxesPerUser", IsNullable = false, Namespace = "")]
        [Group(@"b2249333b9e085ee149c29960c00214e:60")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaximumConcurrentFaxesPerUser
        {
            get => _maximumConcurrentFaxesPerUser;
            set
            {
                MaximumConcurrentFaxesPerUserSpecified = true;
                _maximumConcurrentFaxesPerUser = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumConcurrentFaxesPerUserSpecified { get; set; }

    }
}
