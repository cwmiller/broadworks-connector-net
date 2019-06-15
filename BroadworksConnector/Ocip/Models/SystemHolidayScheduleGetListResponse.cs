using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemHolidayScheduleGetListRequest.
    /// The response contains all the system holiday schedule names.
        /// <see cref="SystemHolidayScheduleGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHolidayScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
        public List<string> HolidayScheduleName {
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
