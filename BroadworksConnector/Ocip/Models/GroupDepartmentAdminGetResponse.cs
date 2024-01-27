using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDepartmentAdminGetRequest.
    /// The response contains the group department administrators profile information.
    /// Replaced by: GroupDepartmentAdminGetResponse22
    /// <see cref="GroupDepartmentAdminGetRequest"/>
    /// <see cref="GroupDepartmentAdminGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:2770""}]")]
    public class GroupDepartmentAdminGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:2770")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentKeySpecified { get; set; }

        protected string _departmentFullPath;

        [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:2770")]
        [MinLength(1)]
        [MaxLength(50)]
        public string DepartmentFullPath
        {
            get => _departmentFullPath;
            set
            {
                DepartmentFullPathSpecified = true;
                _departmentFullPath = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentFullPathSpecified { get; set; }

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:2770")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:2770")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:2770")]
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

    }
}
