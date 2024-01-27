using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3026""}]")]
    public class EnhancedCallLogsResponsePagingControl
    {

        protected int _responseStartIndex;

        [XmlElement(ElementName = "responseStartIndex", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3026")]
        [MinInclusive(1)]
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
        protected bool ResponseStartIndexSpecified { get; set; }

        protected int _responsePageSize;

        [XmlElement(ElementName = "responsePageSize", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3026")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
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
        protected bool ResponsePageSizeSpecified { get; set; }

    }
}
