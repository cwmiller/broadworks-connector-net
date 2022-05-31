using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserEnhancedCallLogsGetListRequest.
    /// Replaced By: UserEnhancedCallLogsGetListResponse14sp4
    /// <see cref="UserEnhancedCallLogsGetListRequest"/>
    /// <see cref="UserEnhancedCallLogsGetListResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42591""}]")]
    public class UserEnhancedCallLogsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> _placed = new List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry>();

        [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42591")]
        public List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> Placed
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

        protected List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> _received = new List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry>();

        [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42591")]
        public List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> Received
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

        protected List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> _missed = new List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry>();

        [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42591")]
        public List<BroadWorksConnector.Ocip.Models.EnhancedCallLogsEntry> Missed
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
