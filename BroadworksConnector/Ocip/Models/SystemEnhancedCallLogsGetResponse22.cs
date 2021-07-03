using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemEnhancedCallLogsGetResponse24.
    /// Response to SystemEnhancedCallLogsGetRequest22.
    /// <see cref="SystemEnhancedCallLogsGetResponse24"/>
    /// <see cref="SystemEnhancedCallLogsGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26614""}]")]
    public class SystemEnhancedCallLogsGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26614")]
        [MinInclusive(100)]
        [MaxInclusive(1000)]
        public int MaxNonPagedResponseSize
        {
            get => _maxNonPagedResponseSize;
            set
            {
                MaxNonPagedResponseSizeSpecified = true;
                _maxNonPagedResponseSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNonPagedResponseSizeSpecified { get; set; }

        private string _eclQueryApplicationURL;

        [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26614")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryApplicationURL
        {
            get => _eclQueryApplicationURL;
            set
            {
                EclQueryApplicationURLSpecified = true;
                _eclQueryApplicationURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryApplicationURLSpecified { get; set; }

        private string _eclQueryDataRepositoryURL;

        [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26614")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryDataRepositoryURL
        {
            get => _eclQueryDataRepositoryURL;
            set
            {
                EclQueryDataRepositoryURLSpecified = true;
                _eclQueryDataRepositoryURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryDataRepositoryURLSpecified { get; set; }

    }
}
