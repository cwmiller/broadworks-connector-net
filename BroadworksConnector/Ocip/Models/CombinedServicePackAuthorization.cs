using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authorize a service pack.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CombinedServicePackAuthorization 
    {

        
        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public string ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
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
