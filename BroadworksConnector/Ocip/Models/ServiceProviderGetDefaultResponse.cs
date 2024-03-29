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
    /// <see cref="ServiceProviderGetDefaultRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4515""}]")]
    public class ServiceProviderGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4515")]
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
        protected bool IsEnterpriseSpecified { get; set; }

        protected string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4515")]
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
        protected bool DefaultDomainSpecified { get; set; }

    }
}
