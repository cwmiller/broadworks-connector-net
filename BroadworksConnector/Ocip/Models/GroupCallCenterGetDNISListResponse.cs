using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDNISListResponse.
    /// Contains a table with column headings: "Name", "Phone Number", "Extension", "Priority", "Is Primary DNIS".
    /// <see cref="GroupCallCenterGetDNISListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4417""}]")]
    public class GroupCallCenterGetDNISListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _displayDNISNumber;

        [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool DisplayDNISNumberSpecified { get; set; }

        protected bool _displayDNISName;

        [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool DisplayDNISNameSpecified { get; set; }

        protected bool _promoteCallsFromPriority1to0;

        [XmlElement(ElementName = "promoteCallsFromPriority1to0", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority1to0Specified { get; set; }

        protected bool _promoteCallsFromPriority2to1;

        [XmlElement(ElementName = "promoteCallsFromPriority2to1", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority2to1Specified { get; set; }

        protected bool _promoteCallsFromPriority3to2;

        [XmlElement(ElementName = "promoteCallsFromPriority3to2", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority3to2Specified { get; set; }

        protected int _promoteCallsFromPriority1to0Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority1to0Seconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority1to0SecondsSpecified { get; set; }

        protected int _promoteCallsFromPriority2to1Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority2to1Seconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority2to1SecondsSpecified { get; set; }

        protected int _promoteCallsFromPriority3to2Seconds;

        [XmlElement(ElementName = "promoteCallsFromPriority3to2Seconds", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
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
        protected bool PromoteCallsFromPriority3to2SecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnisTable;

        [XmlElement(ElementName = "dnisTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4417")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnisTable
        {
            get => _dnisTable;
            set
            {
                DnisTableSpecified = true;
                _dnisTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnisTableSpecified { get; set; }

    }
}
