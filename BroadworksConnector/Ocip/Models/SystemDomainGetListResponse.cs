using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of all system-level domain names.
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode:
    /// systemDefaultDomain
    /// 
    /// Replaced by SystemDomainGetListResponse22 in AS data mode.
    /// <see cref="SystemDomainGetListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8247""}]")]
    public class SystemDomainGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8247")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SystemDefaultDomain
        {
            get => _systemDefaultDomain;
            set
            {
                SystemDefaultDomainSpecified = true;
                _systemDefaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool SystemDefaultDomainSpecified { get; set; }

        private List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8247")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> Domain
        {
            get => _domain;
            set
            {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        protected bool DomainSpecified { get; set; }

    }
}
