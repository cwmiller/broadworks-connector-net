using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a routing device from a route.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingDeleteRouteDeviceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _routeName;

        [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
        public string RouteName {
            get => _routeName;
            set {
                RouteNameSpecified = true;
                _routeName = value;
            }
        }

        [XmlIgnore]
        public bool RouteNameSpecified { get; set; }
        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        public int Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
    }
}
