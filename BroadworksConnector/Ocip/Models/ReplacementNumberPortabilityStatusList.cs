using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Number Portability Query Statuses that replaces a previously
    /// configured list. By convention, an element of this type may be set
    /// to nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3318""}]")]
    public class ReplacementNumberPortabilityStatusList
    {

        private List<string> _status = new List<string>();

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3318")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

    }
}
