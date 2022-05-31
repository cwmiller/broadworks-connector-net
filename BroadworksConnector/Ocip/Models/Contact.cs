using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contact information.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1818""}]")]
    public class Contact
    {

        protected string _contactName;

        [XmlElement(ElementName = "contactName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1818")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ContactName
        {
            get => _contactName;
            set
            {
                ContactNameSpecified = true;
                _contactName = value;
            }
        }

        [XmlIgnore]
        protected bool ContactNameSpecified { get; set; }

        protected string _contactNumber;

        [XmlElement(ElementName = "contactNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1818")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ContactNumber
        {
            get => _contactNumber;
            set
            {
                ContactNumberSpecified = true;
                _contactNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ContactNumberSpecified { get; set; }

        protected string _contactEmail;

        [XmlElement(ElementName = "contactEmail", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1818")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ContactEmail
        {
            get => _contactEmail;
            set
            {
                ContactEmailSpecified = true;
                _contactEmail = value;
            }
        }

        [XmlIgnore]
        protected bool ContactEmailSpecified { get; set; }

    }
}
