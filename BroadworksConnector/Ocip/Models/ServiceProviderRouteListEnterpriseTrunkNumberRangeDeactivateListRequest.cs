using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deactivate number ranges in a service provider.
    /// It is not an error to deactivate an already deactivated number range.
    /// The command fails if executed when system level enterprise trunk number range activation is disabled.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _numberRangeStart;

        [XmlElement(ElementName = "numberRangeStart", IsNullable = false, Namespace = "")]
        public List<string> NumberRangeStart {
            get => _numberRangeStart;
            set {
                NumberRangeStartSpecified = true;
                _numberRangeStart = value;
            }
        }

        [XmlIgnore]
        public bool NumberRangeStartSpecified { get; set; }
        
    }
}
