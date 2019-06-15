using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMailParametersGetListRequest.
    /// Contains a list of system Mail parameters.
        /// <see cref="SystemMailParametersGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMailParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _primaryServerNetAddress;

        [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = false, Namespace = "")]
        public string PrimaryServerNetAddress {
            get => _primaryServerNetAddress;
            set {
                PrimaryServerNetAddressSpecified = true;
                _primaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PrimaryServerNetAddressSpecified { get; set; }
        
        private string _secondaryServerNetAddress;

        [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = false, Namespace = "")]
        public string SecondaryServerNetAddress {
            get => _secondaryServerNetAddress;
            set {
                SecondaryServerNetAddressSpecified = true;
                _secondaryServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool SecondaryServerNetAddressSpecified { get; set; }
        
        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        public string DefaultFromAddress {
            get => _defaultFromAddress;
            set {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }
        
        private string _defaultSubject;

        [XmlElement(ElementName = "defaultSubject", IsNullable = false, Namespace = "")]
        public string DefaultSubject {
            get => _defaultSubject;
            set {
                DefaultSubjectSpecified = true;
                _defaultSubject = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSubjectSpecified { get; set; }
        
        private bool _supportDNSSRVForMailServerAccess;

        [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false, Namespace = "")]
        public bool SupportDNSSRVForMailServerAccess {
            get => _supportDNSSRVForMailServerAccess;
            set {
                SupportDNSSRVForMailServerAccessSpecified = true;
                _supportDNSSRVForMailServerAccess = value;
            }
        }

        [XmlIgnore]
        public bool SupportDNSSRVForMailServerAccessSpecified { get; set; }
        
    }
}
