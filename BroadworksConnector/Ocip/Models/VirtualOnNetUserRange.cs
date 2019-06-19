using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Virtual On-Net User Range.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""179b744b0183abe614e8c32c17c96b7e:350""}]")]
    public class VirtualOnNetUserRange
    {

        private BroadWorksConnector.Ocip.Models.DNRange _dnRange;

        [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        public BroadWorksConnector.Ocip.Models.DNRange DnRange
        {
            get => _dnRange;
            set
            {
                DnRangeSpecified = true;
                _dnRange = value;
            }
        }

        [XmlIgnore]
        public bool DnRangeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtensionRange17 _extensionRange;

        [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        public BroadWorksConnector.Ocip.Models.ExtensionRange17 ExtensionRange
        {
            get => _extensionRange;
            set
            {
                ExtensionRangeSpecified = true;
                _extensionRange = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionRangeSpecified { get; set; }

        private string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FirstName
        {
            get => _firstName;
            set
            {
                FirstNameSpecified = true;
                _firstName = value;
            }
        }

        [XmlIgnore]
        public bool FirstNameSpecified { get; set; }

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        [MinLength(1)]
        [MaxLength(30)]
        public string LastName
        {
            get => _lastName;
            set
            {
                LastNameSpecified = true;
                _lastName = value;
            }
        }

        [XmlIgnore]
        public bool LastNameSpecified { get; set; }

        private string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdFirstName
        {
            get => _callingLineIdFirstName;
            set
            {
                CallingLineIdFirstNameSpecified = true;
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdFirstNameSpecified { get; set; }

        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdLastName
        {
            get => _callingLineIdLastName;
            set
            {
                CallingLineIdLastNameSpecified = true;
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdLastNameSpecified { get; set; }

        private string _virtualOnNetCallTypeName;

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:350")]
        [MinLength(1)]
        [MaxLength(40)]
        public string VirtualOnNetCallTypeName
        {
            get => _virtualOnNetCallTypeName;
            set
            {
                VirtualOnNetCallTypeNameSpecified = true;
                _virtualOnNetCallTypeName = value;
            }
        }

        [XmlIgnore]
        public bool VirtualOnNetCallTypeNameSpecified { get; set; }

    }
}
