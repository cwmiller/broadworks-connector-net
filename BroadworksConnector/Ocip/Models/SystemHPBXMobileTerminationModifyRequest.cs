using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the hPBX mobile termination related configuration parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHPBXMobileTerminationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _routingPrefix;

        [XmlElement(ElementName = "routingPrefix", IsNullable = true, Namespace = "")]
        public string RoutingPrefix {
            get => _routingPrefix;
            set {
                RoutingPrefixSpecified = true;
                _routingPrefix = value;
            }
        }

        [XmlIgnore]
        public bool RoutingPrefixSpecified { get; set; }
        
    }
}
