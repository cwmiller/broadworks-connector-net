using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserFaxMessagingGetRequest17.
    /// <see cref="UserFaxMessagingGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43548""}]")]
    public class UserFaxMessagingGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43548")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43548")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        protected string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:43548")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionSpecified { get; set; }

    }
}
