using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBasicCallLogsGetListRequest14sp4.
    /// <see cref="UserBasicCallLogsGetListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f8236d2e87356bf980f5d808d1d0ceb3:57""}]")]
    public class UserBasicCallLogsGetListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _placed = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f8236d2e87356bf980f5d808d1d0ceb3:57")]
        public List<BroadWorksConnector.Ocip.Models.CallLogsEntry> Placed
        {
            get => _placed;
            set
            {
                PlacedSpecified = true;
                _placed = value;
            }
        }

        [XmlIgnore]
        public bool PlacedSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _received = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f8236d2e87356bf980f5d808d1d0ceb3:57")]
        public List<BroadWorksConnector.Ocip.Models.CallLogsEntry> Received
        {
            get => _received;
            set
            {
                ReceivedSpecified = true;
                _received = value;
            }
        }

        [XmlIgnore]
        public bool ReceivedSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _missed = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f8236d2e87356bf980f5d808d1d0ceb3:57")]
        public List<BroadWorksConnector.Ocip.Models.CallLogsEntry> Missed
        {
            get => _missed;
            set
            {
                MissedSpecified = true;
                _missed = value;
            }
        }

        [XmlIgnore]
        public bool MissedSpecified { get; set; }

    }
}
