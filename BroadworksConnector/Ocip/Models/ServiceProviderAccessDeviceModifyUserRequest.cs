using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify attributes for line/ports assigned on the service provider device profile.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// privateIdentity
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1140""}]")]
    public class ServiceProviderAccessDeviceModifyUserRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1140")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1140")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1140")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        private string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1140")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PrivateIdentity
        {
            get => _privateIdentity;
            set
            {
                PrivateIdentitySpecified = true;
                _privateIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PrivateIdentitySpecified { get; set; }

        private bool _isPrimaryLinePort;

        [XmlElement(ElementName = "isPrimaryLinePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1140")]
        public bool IsPrimaryLinePort
        {
            get => _isPrimaryLinePort;
            set
            {
                IsPrimaryLinePortSpecified = true;
                _isPrimaryLinePort = value;
            }
        }

        [XmlIgnore]
        protected bool IsPrimaryLinePortSpecified { get; set; }

    }
}
