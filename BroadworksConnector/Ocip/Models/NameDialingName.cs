using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Name dialing last and first names.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3940""}]")]
    public class NameDialingName
    {

        protected string _nameDialingLastName;

        [XmlElement(ElementName = "nameDialingLastName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3940")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NameDialingLastName
        {
            get => _nameDialingLastName;
            set
            {
                NameDialingLastNameSpecified = true;
                _nameDialingLastName = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingLastNameSpecified { get; set; }

        protected string _nameDialingFirstName;

        [XmlElement(ElementName = "nameDialingFirstName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3940")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NameDialingFirstName
        {
            get => _nameDialingFirstName;
            set
            {
                NameDialingFirstNameSpecified = true;
                _nameDialingFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool NameDialingFirstNameSpecified { get; set; }

    }
}
