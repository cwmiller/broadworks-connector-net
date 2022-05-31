using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupIntegratedIMPGetRequest21sp1.
    /// The response contains the group Integrated IMP service attributes.
    /// <see cref="GroupIntegratedIMPGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:68""}]")]
    public class GroupIntegratedIMPGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useServiceProviderSetting;

        [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:68")]
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
        protected bool UseServiceProviderSettingSpecified { get; set; }

        protected string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:68")]
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
        protected bool ServiceDomainSpecified { get; set; }

        protected string _effectiveServiceDomain;

        [XmlElement(ElementName = "effectiveServiceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:68")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EffectiveServiceDomain
        {
            get => _effectiveServiceDomain;
            set
            {
                EffectiveServiceDomainSpecified = true;
                _effectiveServiceDomain = value;
            }
        }

        [XmlIgnore]
        protected bool EffectiveServiceDomainSpecified { get; set; }

        protected bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:68")]
        public bool AddServiceProviderInIMPUserId
        {
            get => _addServiceProviderInIMPUserId;
            set
            {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AddServiceProviderInIMPUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType _defaultImpIdType;

        [XmlElement(ElementName = "defaultImpIdType", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:68")]
        public BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType
        {
            get => _defaultImpIdType;
            set
            {
                DefaultImpIdTypeSpecified = true;
                _defaultImpIdType = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultImpIdTypeSpecified { get; set; }

    }
}
