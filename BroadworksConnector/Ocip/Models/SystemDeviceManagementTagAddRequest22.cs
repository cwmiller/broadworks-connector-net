using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a static configuration tag.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// isTagValueEncrypted
    /// tagValueToEncrypt
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7252"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7253""},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7259""}]}]")]
    public class SystemDeviceManagementTagAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _systemDefaultTagSet;

        [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7253")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7253")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7252")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7252")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7259")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7259")]
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

        private bool _isTagValueOverridable;

        [XmlElement(ElementName = "isTagValueOverridable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7252")]
        public bool IsTagValueOverridable
        {
            get => _isTagValueOverridable;
            set
            {
                IsTagValueOverridableSpecified = true;
                _isTagValueOverridable = value;
            }
        }

        [XmlIgnore]
        public bool IsTagValueOverridableSpecified { get; set; }

    }
}
