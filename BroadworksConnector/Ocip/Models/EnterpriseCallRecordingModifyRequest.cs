using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Call Recording attributes for a enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:88""}]")]
    public class EnterpriseCallRecordingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:88")]
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

        protected bool _useCloudPBX;

        [XmlElement(ElementName = "useCloudPBX", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:88")]
        public bool UseCloudPBX
        {
            get => _useCloudPBX;
            set
            {
                UseCloudPBXSpecified = true;
                _useCloudPBX = value;
            }
        }

        [XmlIgnore]
        protected bool UseCloudPBXSpecified { get; set; }

        protected bool _useEnterpriseSetting;

        [XmlElement(ElementName = "useEnterpriseSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:88")]
        public bool UseEnterpriseSetting
        {
            get => _useEnterpriseSetting;
            set
            {
                UseEnterpriseSettingSpecified = true;
                _useEnterpriseSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseEnterpriseSettingSpecified { get; set; }

        protected string _fQDN;

        [XmlElement(ElementName = "FQDN", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:88")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FQDN
        {
            get => _fQDN;
            set
            {
                FQDNSpecified = true;
                _fQDN = value;
            }
        }

        [XmlIgnore]
        protected bool FQDNSpecified { get; set; }

    }
}
