using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a system schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14701""}]")]
    public class SystemScheduleModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14701")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey
        {
            get => _scheduleKey;
            set
            {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleKeySpecified { get; set; }

        private string _newScheduleName;

        [XmlElement(ElementName = "newScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14701")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewScheduleName
        {
            get => _newScheduleName;
            set
            {
                NewScheduleNameSpecified = true;
                _newScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool NewScheduleNameSpecified { get; set; }

    }
}
