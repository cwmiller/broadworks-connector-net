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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:550""}]")]
    public class ActivatableDN
    {

        protected string _dN;

        [XmlElement(ElementName = "DN", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:550")]
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

        protected bool _activate;

        [XmlElement(ElementName = "activate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:550")]
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
