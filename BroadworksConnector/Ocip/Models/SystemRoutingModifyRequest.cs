using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15649""}]")]
    public class SystemRoutingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _isRouteRoundRobin;

        [XmlElement(ElementName = "isRouteRoundRobin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        public bool IsRouteRoundRobin
        {
            get => _isRouteRoundRobin;
            set
            {
                IsRouteRoundRobinSpecified = true;
                _isRouteRoundRobin = value;
            }
        }

        [XmlIgnore]
        protected bool IsRouteRoundRobinSpecified { get; set; }

        protected int _routeTimerSeconds;

        [XmlElement(ElementName = "routeTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        [MinInclusive(1)]
        [MaxInclusive(25)]
        public int RouteTimerSeconds
        {
            get => _routeTimerSeconds;
            set
            {
                RouteTimerSecondsSpecified = true;
                _routeTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RouteTimerSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy _dnsResolvedAddressSelectionPolicy;

        [XmlElement(ElementName = "dnsResolvedAddressSelectionPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        public BroadWorksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy DnsResolvedAddressSelectionPolicy
        {
            get => _dnsResolvedAddressSelectionPolicy;
            set
            {
                DnsResolvedAddressSelectionPolicySpecified = true;
                _dnsResolvedAddressSelectionPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool DnsResolvedAddressSelectionPolicySpecified { get; set; }

        protected int _statefulExpirationMinutes;

        [XmlElement(ElementName = "statefulExpirationMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        [MinInclusive(0)]
        [MaxInclusive(1440)]
        public int StatefulExpirationMinutes
        {
            get => _statefulExpirationMinutes;
            set
            {
                StatefulExpirationMinutesSpecified = true;
                _statefulExpirationMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool StatefulExpirationMinutesSpecified { get; set; }

        protected int _maxAddressesPerHostname;

        [XmlElement(ElementName = "maxAddressesPerHostname", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        [MinInclusive(1)]
        [MaxInclusive(50)]
        public int MaxAddressesPerHostname
        {
            get => _maxAddressesPerHostname;
            set
            {
                MaxAddressesPerHostnameSpecified = true;
                _maxAddressesPerHostname = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAddressesPerHostnameSpecified { get; set; }

        protected int _maxAddressesDuringSetup;

        [XmlElement(ElementName = "maxAddressesDuringSetup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15649")]
        [MinInclusive(1)]
        [MaxInclusive(50)]
        public int MaxAddressesDuringSetup
        {
            get => _maxAddressesDuringSetup;
            set
            {
                MaxAddressesDuringSetupSpecified = true;
                _maxAddressesDuringSetup = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAddressesDuringSetupSpecified { get; set; }

    }
}
