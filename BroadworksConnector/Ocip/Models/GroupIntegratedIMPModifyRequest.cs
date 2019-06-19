using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Integrated IMP service attributes for the group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:87""}]")]
    public class GroupIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:87")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:87")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private bool _useServiceProviderSetting;

        [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:87")]
        public bool UseServiceProviderSetting
        {
            get => _useServiceProviderSetting;
            set
            {
                UseServiceProviderSettingSpecified = true;
                _useServiceProviderSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseServiceProviderSettingSpecified { get; set; }

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:87")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        public bool ServiceDomainSpecified { get; set; }

    }
}
