using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksMobileManagerGetDomainListRequest.
    /// Contains the list of domains.
    /// <see cref="GroupBroadWorksMobileManagerGetDomainListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:2332""}]")]
    public class GroupBroadWorksMobileManagerGetDomainListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _domainName = new List<string>();

        [XmlElement(ElementName = "domainName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2332")]
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
