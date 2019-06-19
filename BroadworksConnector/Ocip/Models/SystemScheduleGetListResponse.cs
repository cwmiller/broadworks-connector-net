using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemScheduleGetListRequest.
    /// The response contains a list of system schedules.
    /// <see cref="SystemScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14654""}]")]
    public class SystemScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _scheduleName = new List<string>();

        [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14654")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> ScheduleName
        {
            get => _scheduleName;
            set
            {
                ScheduleNameSpecified = true;
                _scheduleName = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ScheduleType> _scheduleType = new List<BroadWorksConnector.Ocip.Models.ScheduleType>();

        [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14654")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleType> ScheduleType
        {
            get => _scheduleType;
            set
            {
                ScheduleTypeSpecified = true;
                _scheduleType = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleTypeSpecified { get; set; }

    }
}
