using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderVisualDeviceManagementGetDeviceInfoRequest.
    /// <see cref="ServiceProviderVisualDeviceManagementGetDeviceInfoRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:7025""}]")]
    public class ServiceProviderVisualDeviceManagementGetDeviceInfoResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7025")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        private bool _supportVisualDeviceManagement;

        [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7025")]
        public bool SupportVisualDeviceManagement
        {
            get => _supportVisualDeviceManagement;
            set
            {
                SupportVisualDeviceManagementSpecified = true;
                _supportVisualDeviceManagement = value;
            }
        }

        [XmlIgnore]
        protected bool SupportVisualDeviceManagementSpecified { get; set; }

        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7025")]
        [MinLength(1)]
        [MaxLength(12)]
        public string MacAddress
        {
            get => _macAddress;
            set
            {
                MacAddressSpecified = true;
                _macAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MacAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.PrimaryUserInfo _primaryUser;

        [XmlElement(ElementName = "primaryUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7025")]
        public BroadWorksConnector.Ocip.Models.PrimaryUserInfo PrimaryUser
        {
            get => _primaryUser;
            set
            {
                PrimaryUserSpecified = true;
                _primaryUser = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryUserSpecified { get; set; }

    }
}
