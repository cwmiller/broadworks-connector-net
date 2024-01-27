using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagSetGetListRequest.
    /// The response includes an array of tag set names defined in the system.
    /// The system default tag set name is not part of this response.
    /// 
    /// Replaced by SystemDeviceManagementTagSetGetListResponse22 in AS data mode
    /// <see cref="SystemDeviceManagementTagSetGetListRequest"/>
    /// <see cref="SystemDeviceManagementTagSetGetListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9847""}]")]
    public class SystemDeviceManagementTagSetGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _tagSetName = new List<string>();

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9847")]
        [MinLength(1)]
        [MaxLength(30)]
        public List<string> TagSetName
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
