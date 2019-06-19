using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a static configuration tag.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemDeviceManagementTagAddRequest22
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDeviceManagementTagAddRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4906"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4907""},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4913""}]}]")]
    public class SystemDeviceManagementTagAddRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _systemDefaultTagSet;

        [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4907")]
        public bool SystemDefaultTagSet
        {
            get => _systemDefaultTagSet;
            set
            {
                SystemDefaultTagSetSpecified = true;
                _systemDefaultTagSet = value;
            }
        }

        [XmlIgnore]
        public bool SystemDefaultTagSetSpecified { get; set; }

        private string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4907")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TagSetName
        {
            get => _tagSetName;
            set
            {
                TagSetNameSpecified = true;
                _tagSetName = value;
            }
        }

        [XmlIgnore]
        public bool TagSetNameSpecified { get; set; }

        private string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4906")]
        [MinLength(1)]
        [MaxLength(64)]
        public string TagName
        {
            get => _tagName;
            set
            {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        public bool TagNameSpecified { get; set; }

        private bool _isTagValueEncrypted;

        [XmlElement(ElementName = "isTagValueEncrypted", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4906")]
        public bool IsTagValueEncrypted
        {
            get => _isTagValueEncrypted;
            set
            {
                IsTagValueEncryptedSpecified = true;
                _isTagValueEncrypted = value;
            }
        }

        [XmlIgnore]
        public bool IsTagValueEncryptedSpecified { get; set; }

        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValue
        {
            get => _tagValue;
            set
            {
                TagValueSpecified = true;
                _tagValue = value;
            }
        }

        [XmlIgnore]
        public bool TagValueSpecified { get; set; }

        private string _tagValueToEncrypt;

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValueToEncrypt
        {
            get => _tagValueToEncrypt;
            set
            {
                TagValueToEncryptSpecified = true;
                _tagValueToEncrypt = value;
            }
        }

        [XmlIgnore]
        public bool TagValueToEncryptSpecified { get; set; }

    }
}
