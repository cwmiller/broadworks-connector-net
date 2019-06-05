using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallLogsEntry
    {
        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        private string _callLogId;

        [XmlElement(ElementName = "callLogId", IsNullable = false, Namespace = "")]
        public string CallLogId
        {
            get => _callLogId;
            set
            {
                CallLogIdSpecified = true;
                _callLogId = value;
            }
        }

        [XmlIgnore]
        public bool CallLogIdSpecified { get; set; }
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        private string _time;

        [XmlElement(ElementName = "time", IsNullable = false, Namespace = "")]
        public string Time
        {
            get => _time;
            set
            {
                TimeSpecified = true;
                _time = value;
            }
        }

        [XmlIgnore]
        public bool TimeSpecified { get; set; }
    }
}
