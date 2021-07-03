using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The system Xsi policy profile key.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:5375""}]")]
    public class XsiPolicyProfileKey
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5375")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:5375")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        protected bool LevelSpecified { get; set; }

    }
}
