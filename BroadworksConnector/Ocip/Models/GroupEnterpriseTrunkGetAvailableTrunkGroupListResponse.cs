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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:604""}]")]
    public class GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _trunkGroupName = new List<string>();

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:604")]
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
