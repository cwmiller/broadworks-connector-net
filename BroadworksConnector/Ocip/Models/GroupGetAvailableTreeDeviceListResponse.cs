using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGetAvailableTreeDeviceListRequest.
    /// <see cref="GroupGetAvailableTreeDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5770""}]")]
    public class GroupGetAvailableTreeDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.TreeDeviceInfo> _treeDeviceInfo = new List<BroadWorksConnector.Ocip.Models.TreeDeviceInfo>();

        [XmlElement(ElementName = "treeDeviceInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5770")]
        public List<BroadWorksConnector.Ocip.Models.TreeDeviceInfo> TreeDeviceInfo
        {
            get => _treeDeviceInfo;
            set
            {
                TreeDeviceInfoSpecified = true;
                _treeDeviceInfo = value;
            }
        }

        [XmlIgnore]
        protected bool TreeDeviceInfoSpecified { get; set; }

    }
}
