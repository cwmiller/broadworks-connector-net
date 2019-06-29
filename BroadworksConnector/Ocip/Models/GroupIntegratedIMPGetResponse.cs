using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupIntegratedIMPGetRequest.
    /// The response contains the group Integrated IMP service attributes.
    /// 
    /// Replaced by: GroupIntegratedIMPGetResponse21sp1 in AS data mode
    /// <see cref="GroupIntegratedIMPGetRequest"/>
    /// <see cref="GroupIntegratedIMPGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4652""}]")]
    public class GroupIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useServiceProviderSetting;

        [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4652")]
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

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4652")]
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

    }
}
