using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used in enhanced call logs group and enterprise queries to restrict the set of result
    /// rows when making a request that can result in a large dataset. The client specifies the
    /// starting row and the number of rows requested.
    /// The server only provides those rows in results, if available.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsResponsePagingControl 
    {

        
        private int _responseStartIndex;

        [XmlElement(ElementName = "responseStartIndex", IsNullable = false, Namespace = "")]
        public int ResponseStartIndex {
            get => _responseStartIndex;
            set {
                ResponseStartIndexSpecified = true;
                _responseStartIndex = value;
            }
        }

        [XmlIgnore]
        public bool ResponseStartIndexSpecified { get; set; }
        
        private int _responsePageSize;

        [XmlElement(ElementName = "responsePageSize", IsNullable = false, Namespace = "")]
        public int ResponsePageSize {
            get => _responsePageSize;
            set {
                ResponsePageSizeSpecified = true;
                _responsePageSize = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePageSizeSpecified { get; set; }
        
    }
}
