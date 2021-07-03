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
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode:
    /// systemDefaultDomain
    /// 
    /// Replaced by SystemDomainGetListResponse22V2 in AS data mode.
    /// <see cref="SystemDomainGetListResponse22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26429""}]")]
    public class SystemDomainGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26429")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _domainTable;

        [XmlElement(ElementName = "domainTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26429")]
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
