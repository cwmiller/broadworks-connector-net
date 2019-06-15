using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsGetRequest22.
        /// <see cref="SystemEnhancedCallLogsGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEnhancedCallLogsGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        public int MaxNonPagedResponseSize {
            get => _maxNonPagedResponseSize;
            set {
                MaxNonPagedResponseSizeSpecified = true;
                _maxNonPagedResponseSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxNonPagedResponseSizeSpecified { get; set; }
        
        private string _eclQueryApplicationURL;

        [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = false, Namespace = "")]
        public string EclQueryApplicationURL {
            get => _eclQueryApplicationURL;
            set {
                EclQueryApplicationURLSpecified = true;
                _eclQueryApplicationURL = value;
            }
        }

        [XmlIgnore]
        public bool EclQueryApplicationURLSpecified { get; set; }
        
        private string _eclQueryDataRepositoryURL;

        [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = false, Namespace = "")]
        public string EclQueryDataRepositoryURL {
            get => _eclQueryDataRepositoryURL;
            set {
                EclQueryDataRepositoryURLSpecified = true;
                _eclQueryDataRepositoryURL = value;
            }
        }

        [XmlIgnore]
        public bool EclQueryDataRepositoryURLSpecified { get; set; }
        
    }
}
