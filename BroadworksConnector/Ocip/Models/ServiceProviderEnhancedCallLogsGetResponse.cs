using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEnhancedCallLogsGetRequest.
        /// <see cref="ServiceProviderEnhancedCallLogsGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderEnhancedCallLogsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _maxLoggedCalls;

        [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false, Namespace = "")]
        public int MaxLoggedCalls {
            get => _maxLoggedCalls;
            set {
                MaxLoggedCallsSpecified = true;
                _maxLoggedCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxLoggedCallsSpecified { get; set; }
        
        private int _callExpirationDays;

        [XmlElement(ElementName = "callExpirationDays", IsNullable = false, Namespace = "")]
        public int CallExpirationDays {
            get => _callExpirationDays;
            set {
                CallExpirationDaysSpecified = true;
                _callExpirationDays = value;
            }
        }

        [XmlIgnore]
        public bool CallExpirationDaysSpecified { get; set; }
        
    }
}
