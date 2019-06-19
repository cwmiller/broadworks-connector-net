using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The service policy profile key.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18716""}]")]
    public class ServicePolicyProfileKey
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18716")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServicePolicyProfileCategory _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18716")]
        public BroadWorksConnector.Ocip.Models.ServicePolicyProfileCategory Category
        {
            get => _category;
            set
            {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        public bool CategorySpecified { get; set; }

    }
}
