using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get an Auto Attendant submenu instance.
    /// The response is either GroupAutoAttendantSubmenuGetResponse or ErrorResponse.
    /// This request is only valid for Standard auto attendants.
    /// 
    /// Replaced by: GroupAutoAttendantSubmenuGetRequest20 in AS data mode
    /// <see cref="GroupAutoAttendantSubmenuGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupAutoAttendantSubmenuGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:440""}]")]
    public class GroupAutoAttendantSubmenuGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:440")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:440")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SubmenuId
        {
            get => _submenuId;
            set
            {
                SubmenuIdSpecified = true;
                _submenuId = value;
            }
        }

        [XmlIgnore]
        public bool SubmenuIdSpecified { get; set; }

    }
}
