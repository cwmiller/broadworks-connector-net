using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterStatisticsRange
    {
        private string _start;

        [XmlElement(ElementName = "start", IsNullable = false, Namespace = "")]
        public string Start
        {
            get => _start;
            set
            {
                StartSpecified = true;
                _start = value;
            }
        }

        [XmlIgnore]
        public bool StartSpecified { get; set; }
        private string _end;

        [XmlElement(ElementName = "end", IsNullable = false, Namespace = "")]
        public string End
        {
            get => _end;
            set
            {
                EndSpecified = true;
                _end = value;
            }
        }

        [XmlIgnore]
        public bool EndSpecified { get; set; }
    }
}
