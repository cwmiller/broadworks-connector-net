using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of all group domain names.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5461""}]")]
    public class GroupDomainGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _groupDefaultDomain;

        [XmlElement(ElementName = "groupDefaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5461")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupDefaultDomain
        {
            get => _groupDefaultDomain;
            set
            {
                GroupDefaultDomainSpecified = true;
                _groupDefaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDefaultDomainSpecified { get; set; }

        private List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5461")]
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
