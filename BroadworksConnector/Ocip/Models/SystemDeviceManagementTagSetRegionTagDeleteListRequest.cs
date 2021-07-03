using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a tag override to a region of a static configuration tag set.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8435""}]")]
    public class SystemDeviceManagementTagSetRegionTagDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8435")]
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

        private string _regionName;

        [XmlElement(ElementName = "regionName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8435")]
        [MinLength(1)]
        [MaxLength(64)]
        public string RegionName
        {
            get => _regionName;
            set
            {
                RegionNameSpecified = true;
                _regionName = value;
            }
        }

        [XmlIgnore]
        protected bool RegionNameSpecified { get; set; }

        private List<string> _tagName = new List<string>();

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8435")]
        [MinLength(1)]
        [MaxLength(64)]
        public List<string> TagName
        {
            get => _tagName;
            set
            {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        protected bool TagNameSpecified { get; set; }

    }
}
