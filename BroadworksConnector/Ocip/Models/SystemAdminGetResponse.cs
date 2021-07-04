using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAdminGetRequest.
    /// The response contains the system or provisioning administrators profile information.
    /// <see cref="SystemAdminGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2160""}]")]
    public class SystemAdminGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2160")]
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
        protected bool FirstNameSpecified { get; set; }

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2160")]
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
        protected bool LastNameSpecified { get; set; }

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2160")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemAdminType _adminType;

        [XmlElement(ElementName = "adminType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2160")]
        public BroadWorksConnector.Ocip.Models.SystemAdminType AdminType
        {
            get => _adminType;
            set
            {
                AdminTypeSpecified = true;
                _adminType = value;
            }
        }

        [XmlIgnore]
        protected bool AdminTypeSpecified { get; set; }

        private bool _readOnly;

        [XmlElement(ElementName = "readOnly", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2160")]
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                ReadOnlySpecified = true;
                _readOnly = value;
            }
        }

        [XmlIgnore]
        protected bool ReadOnlySpecified { get; set; }

    }
}
