using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's general routing attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _isRouteRoundRobin;

        [XmlElement(ElementName = "isRouteRoundRobin", IsNullable = false, Namespace = "")]
        public bool IsRouteRoundRobin {
            get => _isRouteRoundRobin;
            set {
                IsRouteRoundRobinSpecified = true;
                _isRouteRoundRobin = value;
            }
        }

        [XmlIgnore]
        public bool IsRouteRoundRobinSpecified { get; set; }
        
        private int _routeTimerSeconds;

        [XmlElement(ElementName = "routeTimerSeconds", IsNullable = false, Namespace = "")]
        public int RouteTimerSeconds {
            get => _routeTimerSeconds;
            set {
                RouteTimerSecondsSpecified = true;
                _routeTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RouteTimerSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy _dnsResolvedAddressSelectionPolicy;

        [XmlElement(ElementName = "dnsResolvedAddressSelectionPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy DnsResolvedAddressSelectionPolicy {
            get => _dnsResolvedAddressSelectionPolicy;
            set {
                DnsResolvedAddressSelectionPolicySpecified = true;
                _dnsResolvedAddressSelectionPolicy = value;
            }
        }

        [XmlIgnore]
        public bool DnsResolvedAddressSelectionPolicySpecified { get; set; }
        
        private int _statefulExpirationMinutes;

        [XmlElement(ElementName = "statefulExpirationMinutes", IsNullable = false, Namespace = "")]
        public int StatefulExpirationMinutes {
            get => _statefulExpirationMinutes;
            set {
                StatefulExpirationMinutesSpecified = true;
                _statefulExpirationMinutes = value;
            }
        }

        [XmlIgnore]
        public bool StatefulExpirationMinutesSpecified { get; set; }
        
        private int _maxAddressesPerHostname;

        [XmlElement(ElementName = "maxAddressesPerHostname", IsNullable = false, Namespace = "")]
        public int MaxAddressesPerHostname {
            get => _maxAddressesPerHostname;
            set {
                MaxAddressesPerHostnameSpecified = true;
                _maxAddressesPerHostname = value;
            }
        }

        [XmlIgnore]
        public bool MaxAddressesPerHostnameSpecified { get; set; }
        
        private int _maxAddressesDuringSetup;

        [XmlElement(ElementName = "maxAddressesDuringSetup", IsNullable = false, Namespace = "")]
        public int MaxAddressesDuringSetup {
            get => _maxAddressesDuringSetup;
            set {
                MaxAddressesDuringSetupSpecified = true;
                _maxAddressesDuringSetup = value;
            }
        }

        [XmlIgnore]
        public bool MaxAddressesDuringSetupSpecified { get; set; }
        
    }
}
