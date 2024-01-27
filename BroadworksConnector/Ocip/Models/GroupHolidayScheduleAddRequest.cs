using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a holiday schedule to a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10287""}]")]
    public class GroupHolidayScheduleAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidayScheduleName
        {
            get => _holidayScheduleName;
            set
            {
                HolidayScheduleNameSpecified = true;
                _holidayScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday01;

        [XmlElement(ElementName = "holiday01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday01
        {
            get => _holiday01;
            set
            {
                Holiday01Specified = true;
                _holiday01 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday01Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday02;

        [XmlElement(ElementName = "holiday02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday02
        {
            get => _holiday02;
            set
            {
                Holiday02Specified = true;
                _holiday02 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday02Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday03;

        [XmlElement(ElementName = "holiday03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday03
        {
            get => _holiday03;
            set
            {
                Holiday03Specified = true;
                _holiday03 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday03Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday04;

        [XmlElement(ElementName = "holiday04", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday04
        {
            get => _holiday04;
            set
            {
                Holiday04Specified = true;
                _holiday04 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday04Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday05;

        [XmlElement(ElementName = "holiday05", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday05
        {
            get => _holiday05;
            set
            {
                Holiday05Specified = true;
                _holiday05 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday05Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday06;

        [XmlElement(ElementName = "holiday06", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday06
        {
            get => _holiday06;
            set
            {
                Holiday06Specified = true;
                _holiday06 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday06Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday07;

        [XmlElement(ElementName = "holiday07", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday07
        {
            get => _holiday07;
            set
            {
                Holiday07Specified = true;
                _holiday07 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday07Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday08;

        [XmlElement(ElementName = "holiday08", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday08
        {
            get => _holiday08;
            set
            {
                Holiday08Specified = true;
                _holiday08 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday08Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday09;

        [XmlElement(ElementName = "holiday09", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday09
        {
            get => _holiday09;
            set
            {
                Holiday09Specified = true;
                _holiday09 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday09Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday10;

        [XmlElement(ElementName = "holiday10", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday10
        {
            get => _holiday10;
            set
            {
                Holiday10Specified = true;
                _holiday10 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday10Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday11;

        [XmlElement(ElementName = "holiday11", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday11
        {
            get => _holiday11;
            set
            {
                Holiday11Specified = true;
                _holiday11 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday11Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday12;

        [XmlElement(ElementName = "holiday12", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday12
        {
            get => _holiday12;
            set
            {
                Holiday12Specified = true;
                _holiday12 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday12Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday13;

        [XmlElement(ElementName = "holiday13", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday13
        {
            get => _holiday13;
            set
            {
                Holiday13Specified = true;
                _holiday13 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday13Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday14;

        [XmlElement(ElementName = "holiday14", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday14
        {
            get => _holiday14;
            set
            {
                Holiday14Specified = true;
                _holiday14 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday14Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday15;

        [XmlElement(ElementName = "holiday15", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday15
        {
            get => _holiday15;
            set
            {
                Holiday15Specified = true;
                _holiday15 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday15Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday16;

        [XmlElement(ElementName = "holiday16", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday16
        {
            get => _holiday16;
            set
            {
                Holiday16Specified = true;
                _holiday16 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday16Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday17;

        [XmlElement(ElementName = "holiday17", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday17
        {
            get => _holiday17;
            set
            {
                Holiday17Specified = true;
                _holiday17 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday17Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday18;

        [XmlElement(ElementName = "holiday18", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday18
        {
            get => _holiday18;
            set
            {
                Holiday18Specified = true;
                _holiday18 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday18Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday19;

        [XmlElement(ElementName = "holiday19", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday19
        {
            get => _holiday19;
            set
            {
                Holiday19Specified = true;
                _holiday19 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday19Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Holiday _holiday20;

        [XmlElement(ElementName = "holiday20", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10287")]
        public BroadWorksConnector.Ocip.Models.Holiday Holiday20
        {
            get => _holiday20;
            set
            {
                Holiday20Specified = true;
                _holiday20 = value;
            }
        }

        [XmlIgnore]
        protected bool Holiday20Specified { get; set; }

    }
}
