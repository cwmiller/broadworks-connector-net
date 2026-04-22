using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Mail system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11740""}]")]
    public class SystemMailParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _primaryServerNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimaryServerNetAddress
        {
            get => _primaryServerNetAddress;
            set
            {
                PrimaryServerNetAddressSpecified = true;
                _primaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryServerNetAddressSpecified { get; set; }

        protected string _secondaryServerNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SecondaryServerNetAddress
        {
            get => _secondaryServerNetAddress;
            set
            {
                SecondaryServerNetAddressSpecified = true;
                _secondaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SecondaryServerNetAddressSpecified { get; set; }

        protected string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = (value != null);
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFromAddressSpecified { get; set; }

        protected string _defaultSubject;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "defaultSubject", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultSubject
        {
            get => _defaultSubject;
            set
            {
                DefaultSubjectSpecified = true;
                _defaultSubject = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSubjectSpecified { get; set; }

        protected bool? _supportDNSSRVForMailServerAccess;

        [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        public bool? SupportDNSSRVForMailServerAccess
        {
            get => _supportDNSSRVForMailServerAccess;
            set
            {
                SupportDNSSRVForMailServerAccessSpecified = (value != null);
                _supportDNSSRVForMailServerAccess = value;
            }
        }

        [XmlIgnore]
        protected bool SupportDNSSRVForMailServerAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SMTPSecureMode? _secureMode;

        [XmlElement(ElementName = "secureMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        public BroadWorksConnector.Ocip.Models.SMTPSecureMode? SecureMode
        {
            get => _secureMode;
            set
            {
                SecureModeSpecified = (value != null);
                _secureMode = value;
            }
        }

        [XmlIgnore]
        protected bool SecureModeSpecified { get; set; }

        protected int? _port;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11740")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

    }
}
