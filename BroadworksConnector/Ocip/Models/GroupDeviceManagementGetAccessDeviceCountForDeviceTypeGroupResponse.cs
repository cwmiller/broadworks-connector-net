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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4205""}]")]
    public class GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _accessDeviceCount;

        [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4205")]
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
