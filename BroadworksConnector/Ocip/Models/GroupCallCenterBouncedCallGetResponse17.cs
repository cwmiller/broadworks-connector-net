using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterBouncedCallGetRequest17.
    /// 
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// enableTransfer
    /// transferPhoneNumber
    /// bounceCallWhenAgentUnavailable
    /// alertCallCenterCallOnHold
    /// alertCallCenterCallOnHoldSeconds
    /// bounceCallCenterCallOnHold
    /// bounceCallCenterCallOnHoldSeconds
    /// <see cref="GroupCallCenterBouncedCallGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:2744""}]")]
    public class GroupCallCenterBouncedCallGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
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
        protected bool IsActiveSpecified { get; set; }

        private int _numberOfRingsBeforeBouncingCall;

        [XmlElement(ElementName = "numberOfRingsBeforeBouncingCall", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
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
        protected bool NumberOfRingsBeforeBouncingCallSpecified { get; set; }

        private bool _enableTransfer;

        [XmlElement(ElementName = "enableTransfer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
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
        protected bool EnableTransferSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
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
        protected bool TransferPhoneNumberSpecified { get; set; }

        private bool _bounceCallWhenAgentUnavailable;

        [XmlElement(ElementName = "bounceCallWhenAgentUnavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
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
        protected bool BounceCallWhenAgentUnavailableSpecified { get; set; }

        private bool _alertCallCenterCallOnHold;

        [XmlElement(ElementName = "alertCallCenterCallOnHold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
        public bool AlertCallCenterCallOnHold
        {
            get => _alertCallCenterCallOnHold;
            set
            {
                AlertCallCenterCallOnHoldSpecified = true;
                _alertCallCenterCallOnHold = value;
            }
        }

        [XmlIgnore]
        protected bool AlertCallCenterCallOnHoldSpecified { get; set; }

        private int _alertCallCenterCallOnHoldSeconds;

        [XmlElement(ElementName = "alertCallCenterCallOnHoldSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int AlertCallCenterCallOnHoldSeconds
        {
            get => _alertCallCenterCallOnHoldSeconds;
            set
            {
                AlertCallCenterCallOnHoldSecondsSpecified = true;
                _alertCallCenterCallOnHoldSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AlertCallCenterCallOnHoldSecondsSpecified { get; set; }

        private bool _bounceCallCenterCallOnHold;

        [XmlElement(ElementName = "bounceCallCenterCallOnHold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
        public bool BounceCallCenterCallOnHold
        {
            get => _bounceCallCenterCallOnHold;
            set
            {
                BounceCallCenterCallOnHoldSpecified = true;
                _bounceCallCenterCallOnHold = value;
            }
        }

        [XmlIgnore]
        protected bool BounceCallCenterCallOnHoldSpecified { get; set; }

        private int _bounceCallCenterCallOnHoldSeconds;

        [XmlElement(ElementName = "bounceCallCenterCallOnHoldSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2744")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int BounceCallCenterCallOnHoldSeconds
        {
            get => _bounceCallCenterCallOnHoldSeconds;
            set
            {
                BounceCallCenterCallOnHoldSecondsSpecified = true;
                _bounceCallCenterCallOnHoldSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool BounceCallCenterCallOnHoldSecondsSpecified { get; set; }

    }
}
