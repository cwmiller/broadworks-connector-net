using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Auto Attendant Business Hours Menu,After Hours Menu,Holiday Menu and Submenus that use this submenu.
    /// The response is either GroupAutoAttendantSubmenuGetUsageListResponse or ErrorResponse.
    /// This request is only valid for Standard auto attendants.
    /// <see cref="GroupAutoAttendantSubmenuGetUsageListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:578""}]")]
    public class GroupAutoAttendantSubmenuGetUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAutoAttendantSubmenuGetUsageListResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:578")]
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

        protected string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:578")]
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
