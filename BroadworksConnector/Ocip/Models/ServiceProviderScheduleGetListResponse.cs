using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderScheduleGetListRequest.
    /// The response contains a list of service provider schedules.
        /// <see cref="ServiceProviderScheduleGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ScheduleKey> _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleKey> ScheduleKey {
            get => _scheduleKey;
            set {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleKeySpecified { get; set; }
        
    }
}
