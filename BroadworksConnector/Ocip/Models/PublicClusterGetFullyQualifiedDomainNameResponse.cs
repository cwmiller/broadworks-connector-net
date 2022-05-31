using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to PublicClusterGetFullyQualifiedDomainNameRequest.
    /// <see cref="PublicClusterGetFullyQualifiedDomainNameRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:521""}]")]
    public class PublicClusterGetFullyQualifiedDomainNameResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _publicClusterFQDN;

        [XmlElement(ElementName = "publicClusterFQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:521")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PublicClusterFQDN
        {
            get => _publicClusterFQDN;
            set
            {
                PublicClusterFQDNSpecified = true;
                _publicClusterFQDN = value;
            }
        }

        [XmlIgnore]
        protected bool PublicClusterFQDNSpecified { get; set; }

    }
}
