using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseBroadWorksMobileManagerGetDomainListRequest.
    /// Contains the list of domains.
    /// <see cref="EnterpriseBroadWorksMobileManagerGetDomainListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:223""}]")]
    public class EnterpriseBroadWorksMobileManagerGetDomainListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _domainName = new List<string>();

        [XmlElement(ElementName = "domainName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:223")]
        [MinLength(1)]
        [MaxLength(100)]
        public List<string> DomainName
        {
            get => _domainName;
            set
            {
                DomainNameSpecified = true;
                _domainName = value;
            }
        }

        [XmlIgnore]
        protected bool DomainNameSpecified { get; set; }

    }
}
