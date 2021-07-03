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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18542""}]")]
    public class SystemThirdPartyEmergencyCallingGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _primaryHELDServerURL;

        [XmlElement(ElementName = "primaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18542")]
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

        private string _secondaryHELDServerURL;

        [XmlElement(ElementName = "secondaryHELDServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18542")]
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

        private string _emergencyRouteNetAddress;

        [XmlElement(ElementName = "emergencyRouteNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18542")]
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

        private int _emergencyRoutePort;

        [XmlElement(ElementName = "emergencyRoutePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18542")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol _emergencyRouteTransport;

        [XmlElement(ElementName = "emergencyRouteTransport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18542")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol EmergencyRouteTransport
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
