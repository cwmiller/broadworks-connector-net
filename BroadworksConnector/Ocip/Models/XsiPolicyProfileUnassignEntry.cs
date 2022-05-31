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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:5388""}]")]
    public class XsiPolicyProfileUnassignEntry
    {

        protected List<string> _name = new List<string>();

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5388")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5388")]
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
