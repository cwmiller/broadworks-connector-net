using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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
    /// If excludeLeafDeviceTypes is specified, leaf device types are excluded in the response returned.  Leaf
    /// device types are device types that have the option supportLinks set to "Support Link to Device" or "Support Link to Device and User".
    /// If onlyTreeDeviceTypes is specified, all available tree device types are returned.  Tree
    /// device types are device types that have the option supportLinks set to "Support Links from Devices".
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// resellerId
    /// excludeLeafDeviceTypes
    /// onlyTreeDeviceTypes
    /// 
    /// The response is either SystemDeviceTypeGetAvailableListResponse22V2 or ErrorResponse.
    /// <see cref="SystemSIPDeviceTypeGetListRequest"/>
    /// <see cref="SystemMGCPDeviceTypeGetListRequest"/>
    /// <see cref="SystemDeviceTypeGetAvailableListResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8821"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8827""}]}]")]
    public class SystemDeviceTypeGetAvailableListRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22V2>
    {

        protected bool _allowConference;

        [XmlElement(ElementName = "allowConference", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool AllowConference
        {
            get => _allowConference;
            set
            {
                AllowConferenceSpecified = true;
                _allowConference = value;
            }
        }

        [XmlIgnore]
        protected bool AllowConferenceSpecified { get; set; }

        protected bool _allowMusicOnHold;

        [XmlElement(ElementName = "allowMusicOnHold", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool AllowMusicOnHold
        {
            get => _allowMusicOnHold;
            set
            {
                AllowMusicOnHoldSpecified = true;
                _allowMusicOnHold = value;
            }
        }

        [XmlIgnore]
        protected bool AllowMusicOnHoldSpecified { get; set; }

        protected bool _onlyConference;

        [XmlElement(ElementName = "onlyConference", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool OnlyConference
        {
            get => _onlyConference;
            set
            {
                OnlyConferenceSpecified = true;
                _onlyConference = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyConferenceSpecified { get; set; }

        protected bool _onlyVideoCapable;

        [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool OnlyVideoCapable
        {
            get => _onlyVideoCapable;
            set
            {
                OnlyVideoCapableSpecified = true;
                _onlyVideoCapable = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyVideoCapableSpecified { get; set; }

        protected bool _onlyOptionalIpAddress;

        [XmlElement(ElementName = "onlyOptionalIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool OnlyOptionalIpAddress
        {
            get => _onlyOptionalIpAddress;
            set
            {
                OnlyOptionalIpAddressSpecified = true;
                _onlyOptionalIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyOptionalIpAddressSpecified { get; set; }

        protected bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8827")]
        public bool ExcludeReseller
        {
            get => _excludeReseller;
            set
            {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeResellerSpecified { get; set; }

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8827")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected bool _excludeLeafDeviceTypes;

        [XmlElement(ElementName = "excludeLeafDeviceTypes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool ExcludeLeafDeviceTypes
        {
            get => _excludeLeafDeviceTypes;
            set
            {
                ExcludeLeafDeviceTypesSpecified = true;
                _excludeLeafDeviceTypes = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeLeafDeviceTypesSpecified { get; set; }

        protected bool _onlyTreeDeviceTypes;

        [XmlElement(ElementName = "onlyTreeDeviceTypes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8821")]
        public bool OnlyTreeDeviceTypes
        {
            get => _onlyTreeDeviceTypes;
            set
            {
                OnlyTreeDeviceTypesSpecified = true;
                _onlyTreeDeviceTypes = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyTreeDeviceTypesSpecified { get; set; }

    }
}
