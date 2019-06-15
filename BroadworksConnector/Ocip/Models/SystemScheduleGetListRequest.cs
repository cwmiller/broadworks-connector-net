using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of a system schedules. The list can be filtered by schedule type.
    /// The response is either a SystemScheduleGetListResponse or an ErrorResponse.
        /// <see cref="SystemScheduleGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemScheduleGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.ScheduleType _scheduleType;

        [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleType ScheduleType {
            get => _scheduleType;
            set {
                ScheduleTypeSpecified = true;
                _scheduleType = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleTypeSpecified { get; set; }
        
    }
}
