using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBasicCallLogsGetListRequest.
    /// Replaced By: UserBasicCallLogsGetListResponse14sp4
    /// <see cref="UserBasicCallLogsGetListRequest"/>
    /// <see cref="UserBasicCallLogsGetListResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39597""}]")]
    public class UserBasicCallLogsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _placed = new List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry>();

        [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39597")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Placed
        {
            get => _placed;
            set
            {
                PlacedSpecified = true;
                _placed = value;
            }
        }

        [XmlIgnore]
        protected bool PlacedSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _received = new List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry>();

        [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39597")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Received
        {
            get => _received;
            set
            {
                ReceivedSpecified = true;
                _received = value;
            }
        }

        [XmlIgnore]
        protected bool ReceivedSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> _missed = new List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry>();

        [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39597")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallLogsEntry> Missed
        {
            get => _missed;
            set
            {
                MissedSpecified = true;
                _missed = value;
            }
        }

        [XmlIgnore]
        protected bool MissedSpecified { get; set; }

    }
}
