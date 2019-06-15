using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of non-obsolete Identity/device profile types defined in the system and resellers. It is possible
    /// to get either all conference device types or all non-conference types. This command is similar
    /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
    /// but gets both SIP and MGCP types.
    /// If excludeReseller is specified, only system level available device types are returned.
    /// If resellerId is specified, all the system level available device types and the device types in the given reseller are returned.
    /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
    /// If neither excludeReseller nor resellerId is specified, all the system level and reseller level available device types are returned.
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// resellerId
    /// 
    /// The response is either SystemDeviceTypeGetAvailableListResponse22 or ErrorResponse.
        /// <see cref="SystemSIPDeviceTypeGetListRequest"/>
        /// <see cref="SystemMGCPDeviceTypeGetListRequest"/>
        /// <see cref="SystemDeviceTypeGetAvailableListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceTypeGetAvailableListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _allowConference;

        [XmlElement(ElementName = "allowConference", IsNullable = false, Namespace = "")]
        public bool AllowConference {
            get => _allowConference;
            set {
                AllowConferenceSpecified = true;
                _allowConference = value;
            }
        }

        [XmlIgnore]
        public bool AllowConferenceSpecified { get; set; }
        
        private bool _allowMusicOnHold;

        [XmlElement(ElementName = "allowMusicOnHold", IsNullable = false, Namespace = "")]
        public bool AllowMusicOnHold {
            get => _allowMusicOnHold;
            set {
                AllowMusicOnHoldSpecified = true;
                _allowMusicOnHold = value;
            }
        }

        [XmlIgnore]
        public bool AllowMusicOnHoldSpecified { get; set; }
        
        private bool _onlyConference;

        [XmlElement(ElementName = "onlyConference", IsNullable = false, Namespace = "")]
        public bool OnlyConference {
            get => _onlyConference;
            set {
                OnlyConferenceSpecified = true;
                _onlyConference = value;
            }
        }

        [XmlIgnore]
        public bool OnlyConferenceSpecified { get; set; }
        
        private bool _onlyVideoCapable;

        [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false, Namespace = "")]
        public bool OnlyVideoCapable {
            get => _onlyVideoCapable;
            set {
                OnlyVideoCapableSpecified = true;
                _onlyVideoCapable = value;
            }
        }

        [XmlIgnore]
        public bool OnlyVideoCapableSpecified { get; set; }
        
        private bool _onlyOptionalIpAddress;

        [XmlElement(ElementName = "onlyOptionalIpAddress", IsNullable = false, Namespace = "")]
        public bool OnlyOptionalIpAddress {
            get => _onlyOptionalIpAddress;
            set {
                OnlyOptionalIpAddressSpecified = true;
                _onlyOptionalIpAddress = value;
            }
        }

        [XmlIgnore]
        public bool OnlyOptionalIpAddressSpecified { get; set; }
        
        private bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        public bool ExcludeReseller {
            get => _excludeReseller;
            set {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        public bool ExcludeResellerSpecified { get; set; }
        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
