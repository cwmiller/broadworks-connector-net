using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:866""}]")]
    public class UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs
    {

        protected List<string> _placedCallLogId = new List<string>();

        [XmlElement(ElementName = "placedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:866")]
        [MinLength(1)]
        [MaxLength(36)]
        public List<string> PlacedCallLogId
        {
            get => _placedCallLogId;
            set
            {
                PlacedCallLogIdSpecified = true;
                _placedCallLogId = value;
            }
        }

        [XmlIgnore]
        protected bool PlacedCallLogIdSpecified { get; set; }

        protected List<string> _receivedCallLogId = new List<string>();

        [XmlElement(ElementName = "receivedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:866")]
        [MinLength(1)]
        [MaxLength(36)]
        public List<string> ReceivedCallLogId
        {
            get => _receivedCallLogId;
            set
            {
                ReceivedCallLogIdSpecified = true;
                _receivedCallLogId = value;
            }
        }

        [XmlIgnore]
        protected bool ReceivedCallLogIdSpecified { get; set; }

        protected List<string> _missedCallLogId = new List<string>();

        [XmlElement(ElementName = "missedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:866")]
        [MinLength(1)]
        [MaxLength(36)]
        public List<string> MissedCallLogId
        {
            get => _missedCallLogId;
            set
            {
                MissedCallLogIdSpecified = true;
                _missedCallLogId = value;
            }
        }

        [XmlIgnore]
        protected bool MissedCallLogIdSpecified { get; set; }

    }
}
