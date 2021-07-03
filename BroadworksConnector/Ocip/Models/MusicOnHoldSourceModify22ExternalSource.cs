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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3230""}]")]
    public class MusicOnHoldSourceModify22ExternalSource
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3230")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint
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

        private bool _authenticationRequired;

        [XmlElement(ElementName = "authenticationRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3230")]
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

        private string _authenticationUserName;

        [XmlElement(ElementName = "authenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3230")]
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

        private string _authenticationPassword;

        [XmlElement(ElementName = "authenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3230")]
        [MinLength(1)]
        [MaxLength(60)]
        public string AuthenticationPassword
        {
            get => _authenticationPassword;
            set
            {
                AuthenticationPasswordSpecified = true;
                _authenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool AuthenticationPasswordSpecified { get; set; }

    }
}
