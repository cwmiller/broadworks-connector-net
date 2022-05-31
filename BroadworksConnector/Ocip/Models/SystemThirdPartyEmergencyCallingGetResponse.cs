using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemThirdPartyEmergencyCallingGetRequest.
    /// The response contains the third-party emergency call service settings for the system.
    /// 
    /// Replaced by: SystemThirdPartyEmergencyCallingGetResponse24
    /// <see cref="SystemThirdPartyEmergencyCallingGetRequest"/>
    /// <see cref="SystemThirdPartyEmergencyCallingGetResponse24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35468""}]")]
    public class SystemThirdPartyEmergencyCallingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _primaryHELDServerURL;

        [XmlElement(ElementName = "primaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35468")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PrimaryHELDServerURL
        {
            get => _primaryHELDServerURL;
            set
            {
                PrimaryHELDServerURLSpecified = true;
                _primaryHELDServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryHELDServerURLSpecified { get; set; }

        protected string _secondaryHELDServerURL;

        [XmlElement(ElementName = "secondaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35468")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SecondaryHELDServerURL
        {
            get => _secondaryHELDServerURL;
            set
            {
                SecondaryHELDServerURLSpecified = true;
                _secondaryHELDServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool SecondaryHELDServerURLSpecified { get; set; }

        protected string _emergencyRouteNetAddress;

        [XmlElement(ElementName = "emergencyRouteNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35468")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmergencyRouteNetAddress
        {
            get => _emergencyRouteNetAddress;
            set
            {
                EmergencyRouteNetAddressSpecified = true;
                _emergencyRouteNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRouteNetAddressSpecified { get; set; }

        protected int _emergencyRoutePort;

        [XmlElement(ElementName = "emergencyRoutePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35468")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int EmergencyRoutePort
        {
            get => _emergencyRoutePort;
            set
            {
                EmergencyRoutePortSpecified = true;
                _emergencyRoutePort = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRoutePortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TransportProtocol _emergencyRouteTransport;

        [XmlElement(ElementName = "emergencyRouteTransport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35468")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol EmergencyRouteTransport
        {
            get => _emergencyRouteTransport;
            set
            {
                EmergencyRouteTransportSpecified = true;
                _emergencyRouteTransport = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyRouteTransportSpecified { get; set; }

    }
}
