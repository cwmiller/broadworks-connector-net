using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get an Auto Attendant submenu instance.
    /// The response is either GroupAutoAttendantSubmenuGetResponse20 or ErrorResponse.
    /// This request is only valid for Standard auto attendants.
    /// <see cref="GroupAutoAttendantSubmenuGetResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ed0640d8ef49eb8b4eaa14d7c6f6c033:516""}]")]
    public class GroupAutoAttendantSubmenuGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:516")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:516")]
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
        protected bool SubmenuIdSpecified { get; set; }

    }
}
