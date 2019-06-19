using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderGetDefaultRequest. All values are default values for
    /// a service provider or enterprise's profile.
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode.
    /// defaultDomain
    /// <see cref="ServiceProviderGetDefaultRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3653""}]")]
    public class ServiceProviderGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3653")]
        public bool IsEnterprise
        {
            get => _isEnterprise;
            set
            {
                IsEnterpriseSpecified = true;
                _isEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool IsEnterpriseSpecified { get; set; }

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3653")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDomain
        {
            get => _defaultDomain;
            set
            {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDomainSpecified { get; set; }

    }
}
