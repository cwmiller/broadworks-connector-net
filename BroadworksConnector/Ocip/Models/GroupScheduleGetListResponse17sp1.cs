using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetListRequest17sp1.
    /// The response contains a list of group schedules. If the group belongs to an enterprise,
    /// it also contains the schedules for the enterprise.
    /// <see cref="GroupScheduleGetListRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6520""}]")]
    public class GroupScheduleGetListResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> _scheduleGlobalKey = new List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey>();

        [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6520")]
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
