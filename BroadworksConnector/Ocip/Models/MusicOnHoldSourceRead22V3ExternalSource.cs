using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3902""}]")]
    public class MusicOnHoldSourceRead22V3ExternalSource
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3902")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        protected bool _authenticationRequired;

        [XmlElement(ElementName = "authenticationRequired", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3902")]
        public bool AuthenticationRequired
        {
            get => _authenticationRequired;
            set
            {
                AuthenticationRequiredSpecified = true;
                _authenticationRequired = value;
            }
        }

        [XmlIgnore]
        protected bool AuthenticationRequiredSpecified { get; set; }

        protected string _authenticationUserName;

        [XmlElement(ElementName = "authenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3902")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AuthenticationUserName
        {
            get => _authenticationUserName;
            set
            {
                AuthenticationUserNameSpecified = true;
                _authenticationUserName = value;
            }
        }

        [XmlIgnore]
        protected bool AuthenticationUserNameSpecified { get; set; }

    }
}
