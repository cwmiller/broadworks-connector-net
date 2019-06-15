using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a system holiday schedule.
    /// The response is either a SystemHolidayScheduleGetResponse or an ErrorResponse.
        /// <see cref="SystemHolidayScheduleGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHolidayScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
        public string HolidayScheduleName {
            get => _holidayScheduleName;
            set {
                HolidayScheduleNameSpecified = true;
                _holidayScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleNameSpecified { get; set; }
        
    }
}
