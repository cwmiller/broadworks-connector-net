using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system time schedule.
    /// The response is either a SystemTimeScheduleGetResponse or an ErrorResponse.
        /// <see cref="SystemTimeScheduleGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTimeScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        public string TimeScheduleName {
            get => _timeScheduleName;
            set {
                TimeScheduleNameSpecified = true;
                _timeScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleNameSpecified { get; set; }
        
    }
}
