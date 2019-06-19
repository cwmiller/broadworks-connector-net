using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsGetRequest22.
    /// <see cref="SystemEnhancedCallLogsGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:210""}]")]
    public class SystemEnhancedCallLogsGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:210")]
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
        public bool MaxNonPagedResponseSizeSpecified { get; set; }

        private string _eclQueryApplicationURL;

        [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:210")]
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
        public bool EclQueryApplicationURLSpecified { get; set; }

        private string _eclQueryDataRepositoryURL;

        [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:210")]
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
        public bool EclQueryDataRepositoryURLSpecified { get; set; }

    }
}
