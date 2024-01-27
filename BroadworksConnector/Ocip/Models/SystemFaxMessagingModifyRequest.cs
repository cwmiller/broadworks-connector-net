using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Fax Messaging.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// statusDurationHours
    /// statusAuditIntervalHours
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b2249333b9e085ee149c29960c00214e:81""}]")]
    public class SystemFaxMessagingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _statusDurationHours;

        [XmlElement(ElementName = "statusDurationHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b2249333b9e085ee149c29960c00214e:81")]
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
        [Optional]
        [Group(@"b2249333b9e085ee149c29960c00214e:81")]
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
        [Optional]
        [Group(@"b2249333b9e085ee149c29960c00214e:81")]
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
