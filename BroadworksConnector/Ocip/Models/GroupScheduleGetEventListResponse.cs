using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetEventListRequest.
    /// The response contains a list of events.
        /// <see cref="GroupScheduleGetEventListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupScheduleGetEventListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        public List<string> EventName {
            get => _eventName;
            set {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        public bool EventNameSpecified { get; set; }
        
    }
}
