using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServiceGetUserAssignableListRequest.
        /// <see cref="ServiceProviderServiceGetUserAssignableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServiceGetUserAssignableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.UserService> _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.UserService> ServiceName {
            get => _serviceName;
            set {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }
        
    }
}
