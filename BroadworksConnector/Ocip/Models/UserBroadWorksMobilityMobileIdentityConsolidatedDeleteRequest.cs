using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a mobile identity from the user's list of mobile identities.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
    /// When a delete request is attempted on the primary mobile identity, the delete will fail unless it is the last mobile identity in the user's list.
    /// 
    /// If deleteExistingDevices is set to true, after the mobile identity is deleted, any device that is only used by the deleted mobile identity prior to the deletion will be deleted if the command is executed with the correct priviledge.
    /// Group administrator or above running this command can delete any group level devices. Service provider administrator or above can delete any service provider and group devices. Provisioning administrator or above can delete any devices.
    /// An ErrorResponse with the type warning will be returned if any device cannot be deleted because of insufficient privilege.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1668""}]")]
    public class UserBroadWorksMobilityMobileIdentityConsolidatedDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1668")]
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

        protected string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1668")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumberSpecified { get; set; }

        protected bool _deleteExistingDevices;

        [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1668")]
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

    }
}
