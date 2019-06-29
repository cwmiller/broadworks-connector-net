using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSpeedDial8GetListRequest.
    /// <see cref="UserSpeedDial8GetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""00c269203c804a240d213a69b1264795:56""}]")]
    public class UserSpeedDial8GetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> _speedDialEntry = new List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry>();

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        [Group(@"00c269203c804a240d213a69b1264795:56")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry
        {
            get => _speedDialEntry;
            set
            {
                SpeedDialEntrySpecified = true;
                _speedDialEntry = value;
            }
        }

        [XmlIgnore]
        protected bool SpeedDialEntrySpecified { get; set; }

    }
}
