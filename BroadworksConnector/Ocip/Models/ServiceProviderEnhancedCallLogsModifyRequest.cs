using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Service Provider level data associated with Enhanced Call Logs.
    /// Configures the maximum number of logged calls and maximum age of your user's call logs.
    /// Log entries are deleted when either of the two limits is reached.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:138""}]")]
    public class ServiceProviderEnhancedCallLogsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:138")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private int _maxLoggedCalls;

        [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:138")]
        [MinInclusive(1)]
        [MaxInclusive(99000)]
        public int MaxLoggedCalls
        {
            get => _maxLoggedCalls;
            set
            {
                MaxLoggedCallsSpecified = true;
                _maxLoggedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxLoggedCallsSpecified { get; set; }

        private int _callExpirationDays;

        [XmlElement(ElementName = "callExpirationDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:138")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int CallExpirationDays
        {
            get => _callExpirationDays;
            set
            {
                CallExpirationDaysSpecified = true;
                _callExpirationDays = value;
            }
        }

        [XmlIgnore]
        protected bool CallExpirationDaysSpecified { get; set; }

    }
}
