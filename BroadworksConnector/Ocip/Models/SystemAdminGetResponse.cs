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
    /// Replaced by: SystemAdminGetResponse22
    /// <see cref="SystemAdminGetRequest"/>
    /// <see cref="SystemAdminGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:8239""}]")]
    public class SystemAdminGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:8239")]
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

        protected string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:8239")]
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

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:8239")]
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

        protected BroadWorksConnector.Ocip.Models.SystemAdminType _adminType;

        [XmlElement(ElementName = "adminType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:8239")]
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

        protected bool _readOnly;

        [XmlElement(ElementName = "readOnly", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:8239")]
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
