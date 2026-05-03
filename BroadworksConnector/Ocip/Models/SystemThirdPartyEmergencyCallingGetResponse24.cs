using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemThirdPartyEmergencyCallingGetRequest24.
    /// The response contains the third-party emergency call service settings for the system.
    /// <see cref="SystemThirdPartyEmergencyCallingGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19124""}]")]
    public class SystemThirdPartyEmergencyCallingGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _primaryHELDServerURL;

        [XmlElement(ElementName = "primaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19124")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PrimaryHELDServerURL
        {
            get => _primaryHELDServerURL;
            set
            {
                PrimaryHELDServerURLSpecified = (value != null);
                _primaryHELDServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryHELDServerURLSpecified { get; set; }

        protected string _secondaryHELDServerURL;

        [XmlElement(ElementName = "secondaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19124")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SecondaryHELDServerURL
        {
            get => _secondaryHELDServerURL;
            set
            {
                SecondaryHELDServerURLSpecified = (value != null);
                _secondaryHELDServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool SecondaryHELDServerURLSpecified { get; set; }

        protected string _emergencyRouteNetAddress;

        [XmlElement(ElementName = "emergencyRouteNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19124")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmergencyRouteNetAddress
        {
            get => _emergencyRouteNetAddress;
            set
            {
                EmergencyRouteNetAddressSpecified = (value != null);
                _emergencyRouteNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRouteNetAddressSpecified { get; set; }

        protected int? _emergencyRoutePort;

        [XmlElement(ElementName = "emergencyRoutePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19124")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? EmergencyRoutePort
        {
            get => _emergencyRoutePort;
            set
            {
                EmergencyRoutePortSpecified = (value != null);
                _emergencyRoutePort = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRoutePortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol? _emergencyRouteTransport;

        [XmlElement(ElementName = "emergencyRouteTransport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19124")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol? EmergencyRouteTransport
        {
            get => _emergencyRouteTransport;
            set
            {
                EmergencyRouteTransportSpecified = (value != null);
                _emergencyRouteTransport = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRouteTransportSpecified { get; set; }

    }
}
