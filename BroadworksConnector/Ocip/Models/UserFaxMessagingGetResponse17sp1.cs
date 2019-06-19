using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserFaxMessagingGetRequest17sp1.
    /// <see cref="UserFaxMessagingGetRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f46f967f937c7dc89ddb3db423383aa4:114""}]")]
    public class UserFaxMessagingGetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"f46f967f937c7dc89ddb3db423383aa4:114")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f46f967f937c7dc89ddb3db423383aa4:114")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f46f967f937c7dc89ddb3db423383aa4:114")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }

        private List<string> _alias = new List<string>();

        [XmlElement(ElementName = "alias", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f46f967f937c7dc89ddb3db423383aa4:114")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> Alias
        {
            get => _alias;
            set
            {
                AliasSpecified = true;
                _alias = value;
            }
        }

        [XmlIgnore]
        public bool AliasSpecified { get; set; }

    }
}
