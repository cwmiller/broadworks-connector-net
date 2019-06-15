using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Call Center queue and agent statistics.
    /// The response is either GroupCallCenterGetInstanceStatisticsResponse14sp9 or ErrorResponse.
        /// <see cref="GroupCallCenterGetInstanceStatisticsResponse14sp9"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetInstanceStatisticsRequest14sp9 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange _statisticsRange;

        [XmlElement(ElementName = "statisticsRange", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange {
            get => _statisticsRange;
            set {
                StatisticsRangeSpecified = true;
                _statisticsRange = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsRangeSpecified { get; set; }
        
    }
}
