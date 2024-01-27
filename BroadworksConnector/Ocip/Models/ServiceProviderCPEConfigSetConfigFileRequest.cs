using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set a new service provider default configuration file for a device type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// When the element configFile is set to nil, the configuration file defined
    /// at the parent level is used.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:2866""}]")]
    public class ServiceProviderCPEConfigSetConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2866")]
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

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2866")]
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

        protected BroadWorksConnector.Ocip.Models.FileResource _configFile;

        [XmlElement(ElementName = "configFile", IsNullable = true, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2866")]
        public BroadWorksConnector.Ocip.Models.FileResource ConfigFile
        {
            get => _configFile;
            set
            {
                ConfigFileSpecified = true;
                _configFile = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigFileSpecified { get; set; }

    }
}
