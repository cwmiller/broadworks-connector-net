using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemGetRoutePointListRequest.
        /// <see cref="SystemRoutePointExternalSystemGetRoutePointListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemGetRoutePointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public List<string> ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
