using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest.
    /// <see cref="GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:708""}]")]
    public class GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _trunkGroupName = new List<string>();

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:708")]
        [MinLength(1)]
        [MaxLength(30)]
        public List<string> TrunkGroupName
        {
            get => _trunkGroupName;
            set
            {
                TrunkGroupNameSpecified = true;
                _trunkGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupNameSpecified { get; set; }

    }
}
