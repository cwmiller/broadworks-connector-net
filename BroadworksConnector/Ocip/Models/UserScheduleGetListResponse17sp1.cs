using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetListRequest17sp1.
    /// The response contains a list of schedules viewable by the user. It contains the schedules
    /// defined for the user and the group the user belongs to. If the user belongs to an enterprise,
    /// the list also contains the schedules defined for the enterprise.
    /// <see cref="UserScheduleGetListRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3741""}]")]
    public class UserScheduleGetListResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> _scheduleGlobalKey = new List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey>();

        [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3741")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> ScheduleGlobalKey
        {
            get => _scheduleGlobalKey;
            set
            {
                ScheduleGlobalKeySpecified = true;
                _scheduleGlobalKey = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleGlobalKeySpecified { get; set; }

    }
}
