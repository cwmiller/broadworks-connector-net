using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceDeviceActivationGetRequest.
    /// The response contains the activation code (if available), the expiry time (if available) and the activation state.
    /// The expiryTime is represented as a timestamp, i.e. the number of milliseconds
    /// since January 1, 1970, 00:00:00 GMT.
    /// <see cref="GroupAccessDeviceDeviceActivationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:541""}]")]
    public class GroupAccessDeviceDeviceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _activationCode;

        [XmlElement(ElementName = "activationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:541")]
        [MinLength(16)]
        [MaxLength(16)]
        public string ActivationCode
        {
            get => _activationCode;
            set
            {
                ActivationCodeSpecified = true;
                _activationCode = value;
            }
        }

        [XmlIgnore]
        protected bool ActivationCodeSpecified { get; set; }

        protected string _expiryTime;

        [XmlElement(ElementName = "expiryTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:541")]
        public string ExpiryTime
        {
            get => _expiryTime;
            set
            {
                ExpiryTimeSpecified = true;
                _expiryTime = value;
            }
        }

        [XmlIgnore]
        protected bool ExpiryTimeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceActivationState _activationState;

        [XmlElement(ElementName = "activationState", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:541")]
        public BroadWorksConnector.Ocip.Models.DeviceActivationState ActivationState
        {
            get => _activationState;
            set
            {
                ActivationStateSpecified = true;
                _activationState = value;
            }
        }

        [XmlIgnore]
        protected bool ActivationStateSpecified { get; set; }

    }
}
