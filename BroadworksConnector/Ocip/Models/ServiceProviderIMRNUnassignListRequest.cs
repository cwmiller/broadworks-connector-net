using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of service provider DNs from the service provider IMRN pool. The DNs then become available for
    /// assignment to groups. It is possible to delete either: a single DN,
    /// or a list of DNs, or a range of DNs, or any combination thereof.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderIMRNUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private List<string> _imrn;

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        public List<string> Imrn {
            get => _imrn;
            set {
                ImrnSpecified = true;
                _imrn = value;
            }
        }

        [XmlIgnore]
        public bool ImrnSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.DNRange> _imrnRange;

        [XmlElement(ElementName = "imrnRange", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> ImrnRange {
            get => _imrnRange;
            set {
                ImrnRangeSpecified = true;
                _imrnRange = value;
            }
        }

        [XmlIgnore]
        public bool ImrnRangeSpecified { get; set; }
        
    }
}
