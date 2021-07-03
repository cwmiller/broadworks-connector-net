using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEnhancedCallLogsGetRequest.
    /// <see cref="ServiceProviderEnhancedCallLogsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:18703""}]")]
    public class ServiceProviderEnhancedCallLogsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxLoggedCalls;

        [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18703")]
        [MinInclusive(1)]
        [MaxInclusive(10000)]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18703")]
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
