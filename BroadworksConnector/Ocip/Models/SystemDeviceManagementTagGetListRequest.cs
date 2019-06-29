using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of custom configuration tags managed by the Device Management System.
    /// The response is either SystemDeviceManagementTagGetListResponse or ErrorResponse.
    /// <see cref="SystemDeviceManagementTagGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7298"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7299""}]}]")]
    public class SystemDeviceManagementTagGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _systemDefaultTagSet;

        [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7299")]
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
        protected bool SystemDefaultTagSetSpecified { get; set; }

        private string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7299")]
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
        protected bool TagSetNameSpecified { get; set; }

    }
}
