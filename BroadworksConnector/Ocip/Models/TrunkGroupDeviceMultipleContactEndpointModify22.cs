using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group device endpoint used in the context of modify that can have multiple contacts.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4353""}]")]
    public class TrunkGroupDeviceMultipleContactEndpointModify22
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4353")]
        [MinLength(1)]
        [MaxLength(30)]
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
        public bool NameSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4353")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        public bool LinePortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementContactList22 _contactList;

        [XmlElement(ElementName = "contactList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4353")]
        public BroadWorksConnector.Ocip.Models.ReplacementContactList22 ContactList
        {
            get => _contactList;
            set
            {
                ContactListSpecified = true;
                _contactList = value;
            }
        }

        [XmlIgnore]
        public bool ContactListSpecified { get; set; }

    }
}
