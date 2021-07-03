using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of communication barring profiles that replaces a previously configured list.
    /// By convention, an element of this type may be set nil to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1503""}]")]
    public class CommunicationBarringProfileReplacementList
    {

        private List<string> _profileName = new List<string>();

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1503")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> ProfileName
        {
            get => _profileName;
            set
            {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileNameSpecified { get; set; }

    }
}
