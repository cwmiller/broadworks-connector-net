using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterGetDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _displayDNISNumber;

        [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.C.OCITable _dnisTable;

        [XmlElement(ElementName = "dnisTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable DnisTable
        {
            get => _dnisTable;
            set
            {
                DnisTableSpecified = true;
                _dnisTable = value;
            }
        }

        [XmlIgnore]
        public bool DnisTableSpecified { get; set; }
    }
}
