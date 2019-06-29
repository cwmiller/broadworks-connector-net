using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSpeedDial100GetListRequest.
    /// 
    /// Replaced by: UserSpeedDial100GetListResponse17Sp1
    /// <see cref="UserSpeedDial100GetListRequest"/>
    /// <see cref="UserSpeedDial100GetListResponse17Sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:23922""}]")]
    public class UserSpeedDial100GetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23922")]
        [MinLength(1)]
        [MaxLength(2)]
        public string Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> _speedDialEntry = new List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry>();

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23922")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry
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
