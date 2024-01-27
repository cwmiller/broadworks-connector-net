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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""cc2c4e50d2e0f1ccbe7f5a9642204822:58""}]")]
    public class UserBasicCallLogsGetListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _placed = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "placed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:58")]
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
        protected bool PlacedSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _received = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "received", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:58")]
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
        protected bool ReceivedSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallLogsEntry> _missed = new List<BroadWorksConnector.Ocip.Models.CallLogsEntry>();

        [XmlElement(ElementName = "missed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:58")]
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
        protected bool MissedSpecified { get; set; }

    }
}
