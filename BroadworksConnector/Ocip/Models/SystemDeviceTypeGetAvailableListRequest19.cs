using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
    /// to get either all conference device types or all non-conferernce types. This command is similar
    /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
    /// but gets both SIP and MGCP types.
    /// The response is either SystemDeviceTypeGetAvailableListResponse19 or ErrorResponse.
    /// Replaced by SystemDeviceTypeGetAvailableListRequest22 in AS data mode.
    /// <see cref="SystemSIPDeviceTypeGetListRequest"/>
    /// <see cref="SystemMGCPDeviceTypeGetListRequest"/>
    /// <see cref="SystemDeviceTypeGetAvailableListResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDeviceTypeGetAvailableListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9867""}]")]
    public class SystemDeviceTypeGetAvailableListRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19>
    {

        protected bool _allowConference;

        [XmlElement(ElementName = "allowConference", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9867")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9867")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9867")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9867")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9867")]
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

    }
}
