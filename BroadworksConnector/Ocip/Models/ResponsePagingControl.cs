using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used in queries to restrict the set of result rows when making a request that can result in
    /// a large dataset. The client specifies the starting row and the number of rows requested.
    /// The server only provides those rows in results, if available.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3416""}]")]
    public class ResponsePagingControl
    {

        private int _responseStartIndex;

        [XmlElement(ElementName = "responseStartIndex", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3416")]
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

        private int _responsePageSize;

        [XmlElement(ElementName = "responsePageSize", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3416")]
        [MinInclusive(1)]
        [MaxInclusive(2000)]
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
