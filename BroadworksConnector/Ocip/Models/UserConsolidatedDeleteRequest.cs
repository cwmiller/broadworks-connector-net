using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a user.
    /// 
    /// If deleteExistingDevices is set to true, after the user is deleted, any device that is only used by the deleted user prior to the deletion will be deleted if the command is executed with the correct priviledge.
    /// Group administrator or above running this command can delete any group level devices. Service provider administrator or above can delete any service provider and group devices. Provisioning administrator or above can delete any devices.
    /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
    /// 
    /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// The response is either a SuccessResponse or ErrorResponse
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1409""}]")]
    public class UserConsolidatedDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1409")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _deleteExistingDevices;

        [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1409")]
        public bool DeleteExistingDevices
        {
            get => _deleteExistingDevices;
            set
            {
                DeleteExistingDevicesSpecified = true;
                _deleteExistingDevices = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteExistingDevicesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1409")]
        public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers
        {
            get => _unassignPhoneNumbers;
            set
            {
                UnassignPhoneNumbersSpecified = true;
                _unassignPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool UnassignPhoneNumbersSpecified { get; set; }

    }
}
