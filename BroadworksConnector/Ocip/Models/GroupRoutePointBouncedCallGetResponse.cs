using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointBouncedCallGetRequest.
    /// <see cref="GroupRoutePointBouncedCallGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:159""}]")]
    public class GroupRoutePointBouncedCallGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:159")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private int _numberOfRingsBeforeBouncingCall;

        [XmlElement(ElementName = "numberOfRingsBeforeBouncingCall", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:159")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int NumberOfRingsBeforeBouncingCall
        {
            get => _numberOfRingsBeforeBouncingCall;
            set
            {
                NumberOfRingsBeforeBouncingCallSpecified = true;
                _numberOfRingsBeforeBouncingCall = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRingsBeforeBouncingCallSpecified { get; set; }

        private bool _enableTransfer;

        [XmlElement(ElementName = "enableTransfer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:159")]
        public bool EnableTransfer
        {
            get => _enableTransfer;
            set
            {
                EnableTransferSpecified = true;
                _enableTransfer = value;
            }
        }

        [XmlIgnore]
        public bool EnableTransferSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:159")]
        [MinLength(1)]
        [MaxLength(161)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferPhoneNumberSpecified { get; set; }

        private bool _bounceCallWhenAgentUnavailable;

        [XmlElement(ElementName = "bounceCallWhenAgentUnavailable", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:159")]
        public bool BounceCallWhenAgentUnavailable
        {
            get => _bounceCallWhenAgentUnavailable;
            set
            {
                BounceCallWhenAgentUnavailableSpecified = true;
                _bounceCallWhenAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        public bool BounceCallWhenAgentUnavailableSpecified { get; set; }

    }
}
