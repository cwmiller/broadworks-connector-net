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
    /// 
    /// Replaced by SystemDomainGetListResponse22V2 in AS data mode.
    /// <see cref="SystemDomainGetListResponse22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26836""}]")]
    public class SystemDomainGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:26836")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:26836")]
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
