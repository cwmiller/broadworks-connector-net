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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:804""}]")]
    public class UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs
    {

        private List<string> _placedCallLogId = new List<string>();

        [XmlElement(ElementName = "placedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:804")]
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

        private List<string> _receivedCallLogId = new List<string>();

        [XmlElement(ElementName = "receivedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:804")]
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

        private List<string> _missedCallLogId = new List<string>();

        [XmlElement(ElementName = "missedCallLogId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:804")]
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
