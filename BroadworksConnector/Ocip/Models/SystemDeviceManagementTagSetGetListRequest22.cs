using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of custom configuration tag sets managed by the Device Management System.
    /// If excludeReseller is set, only system level tag sets are returned.
    /// If resellerId is specified, all system level tag sets and the tag sets in the reseller are returned.
    /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
    /// If neither excludeReseller nor resellerId is specified, all system level and reseller level tag sets are returned.
    /// 
    /// The response is either SystemDeviceManagementTagSetGetListResponse22 or ErrorResponse.
    /// <see cref="SystemDeviceManagementTagSetGetListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7407"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7408""}]}]")]
    public class SystemDeviceManagementTagSetGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7408")]
        public bool ExcludeReseller
        {
            get => _excludeReseller;
            set
            {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        public bool ExcludeResellerSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7408")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }

    }
}
