using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a tag override to a region of a static configuration tag set.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8536""}]")]
    public class SystemDeviceManagementTagSetRegionTagAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8536")]
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

        protected string _regionName;

        [XmlElement(ElementName = "regionName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8536")]
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

        protected List<BroadWorksConnector.Ocip.Models.DeviceManagementTag> _tag = new List<BroadWorksConnector.Ocip.Models.DeviceManagementTag>();

        [XmlElement(ElementName = "tag", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8536")]
        public List<BroadWorksConnector.Ocip.Models.DeviceManagementTag> Tag
        {
            get => _tag;
            set
            {
                TagSpecified = true;
                _tag = value;
            }
        }

        [XmlIgnore]
        protected bool TagSpecified { get; set; }

    }
}
