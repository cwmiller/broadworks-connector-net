using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Xsi policy profile unassign entry contains mutiltipe Xsi policy profile
    /// and a new replacement default xsi policy profile.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:5868""}]")]
    public class XsiPolicyProfileUnassignEntry
    {

        protected List<string> _name = new List<string>();

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5868")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _newDefault;

        [XmlElement(ElementName = "newDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5868")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewDefault
        {
            get => _newDefault;
            set
            {
                NewDefaultSpecified = true;
                _newDefault = value;
            }
        }

        [XmlIgnore]
        protected bool NewDefaultSpecified { get; set; }

    }
}
