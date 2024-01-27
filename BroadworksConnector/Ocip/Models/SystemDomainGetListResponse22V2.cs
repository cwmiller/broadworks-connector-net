using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a table of all matching system-level domain names and all matching reseller level domains.
    /// The column headings are: "Domain Name" and "Reseller Id".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9642""}]")]
    public class SystemDomainGetListResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9642")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _domainTable;

        [XmlElement(ElementName = "domainTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9642")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DomainTable
        {
            get => _domainTable;
            set
            {
                DomainTableSpecified = true;
                _domainTable = value;
            }
        }

        [XmlIgnore]
        protected bool DomainTableSpecified { get; set; }

    }
}
