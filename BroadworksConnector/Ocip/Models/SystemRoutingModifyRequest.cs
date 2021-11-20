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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15433""}]")]
    public class SystemRoutingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _isRouteRoundRobin;

        [XmlElement(ElementName = "isRouteRoundRobin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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

        private int _routeTimerSeconds;

        [XmlElement(ElementName = "routeTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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

        private BroadWorksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy _dnsResolvedAddressSelectionPolicy;

        [XmlElement(ElementName = "dnsResolvedAddressSelectionPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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

        private int _statefulExpirationMinutes;

        [XmlElement(ElementName = "statefulExpirationMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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

        private int _maxAddressesPerHostname;

        [XmlElement(ElementName = "maxAddressesPerHostname", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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

        private int _maxAddressesDuringSetup;

        [XmlElement(ElementName = "maxAddressesDuringSetup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15433")]
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
