using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequest.
    /// <see cref="GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:3942""}]")]
    public class GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _accessDeviceCount;

        [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3942")]
        public int AccessDeviceCount
        {
            get => _accessDeviceCount;
            set
            {
                AccessDeviceCountSpecified = true;
                _accessDeviceCount = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceCountSpecified { get; set; }

    }
}
