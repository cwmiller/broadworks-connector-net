using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTimeScheduleGetRequest.
    /// The response contains the group's time schedule information.
    /// <see cref="GroupTimeScheduleGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:13084""}]")]
    public class GroupTimeScheduleGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeScheduleName
        {
            get => _timeScheduleName;
            set
            {
                TimeScheduleNameSpecified = true;
                _timeScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval01;

        [XmlElement(ElementName = "timeInterval01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval01
        {
            get => _timeInterval01;
            set
            {
                TimeInterval01Specified = true;
                _timeInterval01 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval01Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval02;

        [XmlElement(ElementName = "timeInterval02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval02
        {
            get => _timeInterval02;
            set
            {
                TimeInterval02Specified = true;
                _timeInterval02 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval02Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval03;

        [XmlElement(ElementName = "timeInterval03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval03
        {
            get => _timeInterval03;
            set
            {
                TimeInterval03Specified = true;
                _timeInterval03 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval03Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval04;

        [XmlElement(ElementName = "timeInterval04", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval04
        {
            get => _timeInterval04;
            set
            {
                TimeInterval04Specified = true;
                _timeInterval04 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval04Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval05;

        [XmlElement(ElementName = "timeInterval05", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval05
        {
            get => _timeInterval05;
            set
            {
                TimeInterval05Specified = true;
                _timeInterval05 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval05Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval06;

        [XmlElement(ElementName = "timeInterval06", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval06
        {
            get => _timeInterval06;
            set
            {
                TimeInterval06Specified = true;
                _timeInterval06 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval06Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval07;

        [XmlElement(ElementName = "timeInterval07", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval07
        {
            get => _timeInterval07;
            set
            {
                TimeInterval07Specified = true;
                _timeInterval07 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval07Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval08;

        [XmlElement(ElementName = "timeInterval08", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval08
        {
            get => _timeInterval08;
            set
            {
                TimeInterval08Specified = true;
                _timeInterval08 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval08Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval09;

        [XmlElement(ElementName = "timeInterval09", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval09
        {
            get => _timeInterval09;
            set
            {
                TimeInterval09Specified = true;
                _timeInterval09 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval09Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval10;

        [XmlElement(ElementName = "timeInterval10", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval10
        {
            get => _timeInterval10;
            set
            {
                TimeInterval10Specified = true;
                _timeInterval10 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval10Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval11;

        [XmlElement(ElementName = "timeInterval11", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval11
        {
            get => _timeInterval11;
            set
            {
                TimeInterval11Specified = true;
                _timeInterval11 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval11Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval12;

        [XmlElement(ElementName = "timeInterval12", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval12
        {
            get => _timeInterval12;
            set
            {
                TimeInterval12Specified = true;
                _timeInterval12 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval12Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval13;

        [XmlElement(ElementName = "timeInterval13", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval13
        {
            get => _timeInterval13;
            set
            {
                TimeInterval13Specified = true;
                _timeInterval13 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval13Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval14;

        [XmlElement(ElementName = "timeInterval14", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval14
        {
            get => _timeInterval14;
            set
            {
                TimeInterval14Specified = true;
                _timeInterval14 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval14Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval15;

        [XmlElement(ElementName = "timeInterval15", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval15
        {
            get => _timeInterval15;
            set
            {
                TimeInterval15Specified = true;
                _timeInterval15 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval15Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval16;

        [XmlElement(ElementName = "timeInterval16", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval16
        {
            get => _timeInterval16;
            set
            {
                TimeInterval16Specified = true;
                _timeInterval16 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval16Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval17;

        [XmlElement(ElementName = "timeInterval17", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval17
        {
            get => _timeInterval17;
            set
            {
                TimeInterval17Specified = true;
                _timeInterval17 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval17Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval18;

        [XmlElement(ElementName = "timeInterval18", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval18
        {
            get => _timeInterval18;
            set
            {
                TimeInterval18Specified = true;
                _timeInterval18 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval18Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval19;

        [XmlElement(ElementName = "timeInterval19", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval19
        {
            get => _timeInterval19;
            set
            {
                TimeInterval19Specified = true;
                _timeInterval19 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval19Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeInterval _timeInterval20;

        [XmlElement(ElementName = "timeInterval20", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13084")]
        public BroadWorksConnector.Ocip.Models.TimeInterval TimeInterval20
        {
            get => _timeInterval20;
            set
            {
                TimeInterval20Specified = true;
                _timeInterval20 = value;
            }
        }

        [XmlIgnore]
        protected bool TimeInterval20Specified { get; set; }

    }
}
