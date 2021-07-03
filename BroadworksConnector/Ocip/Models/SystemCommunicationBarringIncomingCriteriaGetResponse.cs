using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringIncomingCriteriaGetRequest.
    /// The response contains the Communication Barring Incoming Criteria information.
    /// 
    /// Replaced by: SystemCommunicationBarringIncomingCriteriaGetResponse22
    /// <see cref="SystemCommunicationBarringIncomingCriteriaGetRequest"/>
    /// <see cref="SystemCommunicationBarringIncomingCriteriaGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7581""}]")]
    public class SystemCommunicationBarringIncomingCriteriaGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7581")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7581")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7581")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        private List<string> _matchNumberPortabilityStatus = new List<string>();

        [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7581")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> MatchNumberPortabilityStatus
        {
            get => _matchNumberPortabilityStatus;
            set
            {
                MatchNumberPortabilityStatusSpecified = true;
                _matchNumberPortabilityStatus = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNumberPortabilityStatusSpecified { get; set; }

    }
}
