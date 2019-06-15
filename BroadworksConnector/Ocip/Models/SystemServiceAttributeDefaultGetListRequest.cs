using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the default attributes for a service that are used when assigning the feature.
    /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
        /// <see cref="SystemServiceAttributeDefaultGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServiceAttributeDefaultGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceCategory _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceCategory ServiceName {
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
