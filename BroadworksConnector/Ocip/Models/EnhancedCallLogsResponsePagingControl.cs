using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnhancedCallLogsResponsePagingControl
    {
        private int _responseStartIndex;

        [XmlElement(ElementName = "responseStartIndex", IsNullable = false, Namespace = "")]
        public int ResponseStartIndex
        {
            get => _responseStartIndex;
            set
            {
                ResponseStartIndexSpecified = true;
                _responseStartIndex = value;
            }
        }

        [XmlIgnore]
        public bool ResponseStartIndexSpecified { get; set; }
        private int _responsePageSize;

        [XmlElement(ElementName = "responsePageSize", IsNullable = false, Namespace = "")]
        public int ResponsePageSize
        {
            get => _responsePageSize;
            set
            {
                ResponsePageSizeSpecified = true;
                _responsePageSize = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePageSizeSpecified { get; set; }
    }
}
