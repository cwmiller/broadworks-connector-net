using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the setting that are configured for all the DNIS in a Call Center.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5160""}]")]
    public class GroupCallCenterModifyDNISParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
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

        private bool _displayDNISNumber;

        [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        public bool DisplayDNISNumber
        {
            get => _displayDNISNumber;
            set
            {
                DisplayDNISNumberSpecified = true;
                _displayDNISNumber = value;
            }
        }

        [XmlIgnore]
        public bool DisplayDNISNumberSpecified { get; set; }

        private bool _displayDNISName;

        [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        public bool DisplayDNISName
        {
            get => _displayDNISName;
            set
            {
                DisplayDNISNameSpecified = true;
                _displayDNISName = value;
            }
        }

        [XmlIgnore]
        public bool DisplayDNISNameSpecified { get; set; }

        private bool _promoteCallsFromPriority1to0;

        [XmlElement(ElementName = "promoteCallsFromPriority1to0", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        public bool PromoteCallsFromPriority1to0
        {
            get => _promoteCallsFromPriority1to0;
            set
            {
                PromoteCallsFromPriority1to0Specified = true;
                _promoteCallsFromPriority1to0 = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority1to0Specified { get; set; }

        private bool _promoteCallsFromPriority2to1;

        [XmlElement(ElementName = "promoteCallsFromPriority2to1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        public bool PromoteCallsFromPriority2to1
        {
            get => _promoteCallsFromPriority2to1;
            set
            {
                PromoteCallsFromPriority2to1Specified = true;
                _promoteCallsFromPriority2to1 = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority2to1Specified { get; set; }

        private bool _promoteCallsFromPriority3to2;

        [XmlElement(ElementName = "promoteCallsFromPriority3to2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        public bool PromoteCallsFromPriority3to2
        {
            get => _promoteCallsFromPriority3to2;
            set
            {
                PromoteCallsFromPriority3to2Specified = true;
                _promoteCallsFromPriority3to2 = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority3to2Specified { get; set; }

        private int _promoteCallsFromPriority1to0Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority1to0Seconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        [MinInclusive(1)]
        [MaxInclusive(1800)]
        public int PromoteCallsFromPriority1to0Seconds
        {
            get => _promoteCallsFromPriority1to0Seconds;
            set
            {
                PromoteCallsFromPriority1to0SecondsSpecified = true;
                _promoteCallsFromPriority1to0Seconds = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority1to0SecondsSpecified { get; set; }

        private int _promoteCallsFromPriority2to1Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority2to1Seconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        [MinInclusive(1)]
        [MaxInclusive(1800)]
        public int PromoteCallsFromPriority2to1Seconds
        {
            get => _promoteCallsFromPriority2to1Seconds;
            set
            {
                PromoteCallsFromPriority2to1SecondsSpecified = true;
                _promoteCallsFromPriority2to1Seconds = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority2to1SecondsSpecified { get; set; }

        private int _promoteCallsFromPriority3to2Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority3to2Seconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5160")]
        [MinInclusive(1)]
        [MaxInclusive(1800)]
        public int PromoteCallsFromPriority3to2Seconds
        {
            get => _promoteCallsFromPriority3to2Seconds;
            set
            {
                PromoteCallsFromPriority3to2SecondsSpecified = true;
                _promoteCallsFromPriority3to2Seconds = value;
            }
        }

        [XmlIgnore]
        public bool PromoteCallsFromPriority3to2SecondsSpecified { get; set; }

    }
}
