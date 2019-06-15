using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authorize a group service.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CombinedGroupServiceAuthorization 
    {

        
        private BroadWorksConnector.Ocip.Models.GroupService _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupService ServiceName {
            get => _serviceName;
            set {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity {
            get => _authorizedQuantity;
            set {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AuthorizedQuantitySpecified { get; set; }
        
    }
}
