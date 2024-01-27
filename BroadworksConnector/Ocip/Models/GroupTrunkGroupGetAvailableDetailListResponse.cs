using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetAvailableDetailListRequest.
    /// <see cref="GroupTrunkGroupGetAvailableDetailListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8237""}]")]
    public class GroupTrunkGroupGetAvailableDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> _trunkGroup = new List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup>();

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8237")]
        public List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> TrunkGroup
        {
            get => _trunkGroup;
            set
            {
                TrunkGroupSpecified = true;
                _trunkGroup = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupSpecified { get; set; }

    }
}
