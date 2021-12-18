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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8523""}]")]
    public class GroupTrunkGroupGetAvailableDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> _trunkGroup = new List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup>();

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8523")]
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
