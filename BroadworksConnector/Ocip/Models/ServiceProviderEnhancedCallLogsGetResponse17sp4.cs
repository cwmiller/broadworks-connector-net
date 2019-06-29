using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEnhancedCallLogsGetRequest17sp4.
    /// <see cref="ServiceProviderEnhancedCallLogsGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:161""}]")]
    public class ServiceProviderEnhancedCallLogsGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxLoggedCalls;

        [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:161")]
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
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:161")]
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
