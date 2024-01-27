using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterCurrentAndPastDNISGetListRequest.
    /// <see cref="GroupCallCenterCurrentAndPastDNISGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:3135""}]")]
    public class GroupCallCenterCurrentAndPastDNISGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _name = new List<string>();

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3135")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected List<string> _deletedName = new List<string>();

        [XmlElement(ElementName = "deletedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3135")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> DeletedName
        {
            get => _deletedName;
            set
            {
                DeletedNameSpecified = true;
                _deletedName = value;
            }
        }

        [XmlIgnore]
        protected bool DeletedNameSpecified { get; set; }

    }
}
