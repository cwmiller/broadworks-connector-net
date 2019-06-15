using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMaliciousCallTraceGetRequest.
        /// <see cref="UserMaliciousCallTraceGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMaliciousCallTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection _traceTypeSelection;

        [XmlElement(ElementName = "traceTypeSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection TraceTypeSelection {
            get => _traceTypeSelection;
            set {
                TraceTypeSelectionSpecified = true;
                _traceTypeSelection = value;
            }
        }

        [XmlIgnore]
        public bool TraceTypeSelectionSpecified { get; set; }
        
        private bool _traceForTimePeriod;

        [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false, Namespace = "")]
        public bool TraceForTimePeriod {
            get => _traceForTimePeriod;
            set {
                TraceForTimePeriodSpecified = true;
                _traceForTimePeriod = value;
            }
        }

        [XmlIgnore]
        public bool TraceForTimePeriodSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MaliciousCallTraceTimePeriod _traceTimePeriod;

        [XmlElement(ElementName = "traceTimePeriod", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MaliciousCallTraceTimePeriod TraceTimePeriod {
            get => _traceTimePeriod;
            set {
                TraceTimePeriodSpecified = true;
                _traceTimePeriod = value;
            }
        }

        [XmlIgnore]
        public bool TraceTimePeriodSpecified { get; set; }
        
    }
}
