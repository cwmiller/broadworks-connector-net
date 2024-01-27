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
    /// Replaced by SystemDomainGetListResponse22 in AS data mode.
    /// <see cref="SystemDomainGetListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10334""}]")]
    public class SystemDomainGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10334")]
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

        protected List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10334")]
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
