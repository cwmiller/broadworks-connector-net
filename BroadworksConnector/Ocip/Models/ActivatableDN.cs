using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Activatable directory Number in E164 Format.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:550""}]")]
    public class ActivatableDN
    {

        private string _dN;

        [XmlElement(ElementName = "DN", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:550")]
        [MinLength(1)]
        [MaxLength(23)]
        public string DN
        {
            get => _dN;
            set
            {
                DNSpecified = true;
                _dN = value;
            }
        }

        [XmlIgnore]
        protected bool DNSpecified { get; set; }

        private bool _activate;

        [XmlElement(ElementName = "activate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:550")]
        public bool Activate
        {
            get => _activate;
            set
            {
                ActivateSpecified = true;
                _activate = value;
            }
        }

        [XmlIgnore]
        protected bool ActivateSpecified { get; set; }

    }
}
